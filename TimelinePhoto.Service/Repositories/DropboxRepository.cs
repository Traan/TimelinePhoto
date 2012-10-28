﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimelinePhoto.Service.DomainModels;
using DropNet;
using System.IO;
using DropNet.Models;

namespace TimelinePhoto.Service.Repositories
{
    public class DropboxRepository : Repository, ITimelinePhotoRepository
    {
        private const string IMAGE_FOLDER_PATH = @"Images\Dropbox";
        private const string IMAGE_THUMBNAIL_FOLDER_PATH = @"Images\Dropbox\Thumbnails";

        private DropNetClient _client;
        private MetaData _dropboxImageFolderMetaData;
        private string _cacheKey = "dropbox_{0}"; 

        public DropboxRepository(string appKey, string appSecret, string userToken, string userSecret, string folderPath)
        {
            if (!string.IsNullOrEmpty(appKey) && !string.IsNullOrEmpty(appSecret) && !string.IsNullOrEmpty(userToken) && !string.IsNullOrEmpty(userSecret) && !string.IsNullOrEmpty(folderPath))
            {
                _client = new DropNetClient(apiKey: appKey, appSecret: appSecret, userToken: userToken, userSecret: userSecret);

                _cacheKey = string.Format(_cacheKey, appKey);
                var cachedMetaData = LoadFromCache<MetaData>(cacheKey: _cacheKey);
                if (cachedMetaData != null)
                {
                    _dropboxImageFolderMetaData = cachedMetaData;
                }
                else
                {
                    _dropboxImageFolderMetaData = _client.GetMetaData(path: folderPath);
                    AddToCache(item: _dropboxImageFolderMetaData, cacheKey: _cacheKey, absoluteExpiration: DateTime.Now.AddHours(1));
                }
            }
        }

        public IEnumerable<Entry> GetEntries()
        {
            return _dropboxImageFolderMetaData.Contents.Select(photo => new Entry
            {
                Title = photo.Name,
                Date = photo.ModifiedDate,
                Text = string.Empty,
                Asset = new Asset
                {
                    Type = "dropbox",
                    Media = GetImageLink(photo.Path),
                    Thumbnail = GetImageThumbnailLink(photo.Path)
                }
            });
        }

        public byte[] GetImageData(string id, string thumb)
        {
            string filePath;
            DropNet.Models.ThumbnailSize size;

            if (!string.IsNullOrEmpty(thumb) && bool.Parse(thumb))
	        {
		        filePath = string.Format(@"{0}\{1}\{2}", System.Web.HttpContext.Current.Request.PhysicalApplicationPath, IMAGE_THUMBNAIL_FOLDER_PATH, id);
                size = DropNet.Models.ThumbnailSize.Small;
	        }
            else
            {
                filePath = string.Format(@"{0}\{1}\{2}", System.Web.HttpContext.Current.Request.PhysicalApplicationPath, IMAGE_FOLDER_PATH, id);
                size = DropNet.Models.ThumbnailSize.ExtraLarge;
            }

            if (!File.Exists(filePath))
            {
                var data = _client.GetThumbnail(file: GetImageMetaData(filename: id),
                                                size: size);
                File.WriteAllBytes(path: filePath, bytes: data);
            }
            return File.ReadAllBytes(path: filePath);
        }

        private Uri GetImageLink(string path)
        {
            var uriBuilder = new UriBuilder(uri: IMAGE_HANDLER_URL);
            uriBuilder.Query = string.Format("{0}={1}", IMAGE_ID_QUERYSTRING, Path.GetFileName(path));
            return uriBuilder.Uri;
        }

        private Uri GetImageThumbnailLink(string path)
        {
            var uriBuilder = new UriBuilder(uri: IMAGE_HANDLER_URL);
            uriBuilder.Query = string.Format("{0}={1}&{2}=true", IMAGE_ID_QUERYSTRING, Path.GetFileName(path), IMAGE_THUMBNAIL_QUERYSTRING);
            return uriBuilder.Uri;
        }

        private MetaData GetImageMetaData(string filename)
        {
            return _dropboxImageFolderMetaData.Contents.FirstOrDefault(file => file.Name == filename);
        }
        
    }
}
