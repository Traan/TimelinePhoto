using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using PhotoBlog.Service.DomainModels;
using PhotoBlog.Service.XmlModels.Flickr;

namespace PhotoBlog.Service.Repositories
{
    public class FlickrRepository : Repository, IPhotoBlogRepository
    {
        private readonly string _cacheKey = "flickr_{0}";
        private readonly Feed _feed;

        protected Feed Feed {get { return _feed; }}

        public FlickrRepository(Uri rssUrl)
        {
            if (rssUrl != null && !string.IsNullOrEmpty(rssUrl.ToString()))
            {
                _cacheKey = string.Format(_cacheKey, rssUrl);

                var cachedFeed = LoadFromCache<Feed>(cacheKey: _cacheKey);
                if (cachedFeed != null)
                {
                    _feed = cachedFeed;
                }
                else
                {
                    _feed = SyndicationFeed.Load<Feed>(reader: XmlReader.Create(inputUri: rssUrl.ToString()));
                    AddToCache(item: _feed, cacheKey: _cacheKey, absoluteExpiration: DateTime.Now.AddHours(1));
                }
            }
            else
            {
                throw new Exception("rssUrl can not be null or empty");
            }
        }

        public IEnumerable<Entry> GetEntries()
        {
            return Feed.Items.Select(item => new Entry
                                                 {
                                                     Title = ((Item)item).Title,
                                                     Date = item.PublishDate.Date,
                                                     Text = ((Item)item).Description != null ? ((Item)item).Description.Value : string.Empty,
                                                     Asset = new Asset
                                                                 {
                                                                     Credit = ((Item)item).Credit.Value,
                                                                     Type = "flickr",
                                                                     Media = item.Links.FirstOrDefault().Uri
                                                                 }
                                                 });
        }
    }
}
