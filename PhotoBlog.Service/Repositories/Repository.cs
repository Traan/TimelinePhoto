using System;
using System.Web;
using System.Web.Caching;

namespace PhotoBlog.Service.Repositories
{
    public abstract class Repository
    {
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
