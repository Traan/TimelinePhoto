using System;
using System.Web;
using System.Web.Caching;

namespace TimelinePhoto.Service.Repositories
{
    public abstract class Repository
    {
        public const string IMAGE_HANDLER_URL = "http://timeline.local/Image.ashx";
        public const string IMAGE_ID_QUERYSTRING = "id";
        public const string IMAGE_THUMBNAIL_QUERYSTRING = "thumb";

        public void AddToCache<T>(T item, string cacheKey, DateTime absoluteExpiration)
        {
            HttpRuntime.Cache.Insert(key: cacheKey, 
                                     value: item, 
                                     dependencies: null,
                                     absoluteExpiration: absoluteExpiration,
                                     slidingExpiration: Cache.NoSlidingExpiration);
        }

        public T LoadFromCache<T>(string cacheKey) where T : class 
        {
            var item = HttpRuntime.Cache.Get(cacheKey) as T;
            return item;
        }
    }
}
