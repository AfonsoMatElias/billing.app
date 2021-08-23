using System;
using Billing.Shared.Helpers;
using Microsoft.Extensions.Caching.Memory;

namespace Billing.Service.Data
{
    public class CacheContext
    {
        public CacheContext(IMemoryCache cache)
        {
            this.cache = cache;
            this.cacheEntryOptions = new MemoryCacheEntryOptions {
                AbsoluteExpiration = DateTime.Now.AddDays( int.Parse(IoC.Configuration["CacheExpirationDays"])),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromTicks(DateTime.Now.Ticks)
            };
        }

        private IMemoryCache cache;
        private MemoryCacheEntryOptions cacheEntryOptions;

        public T Get<T>(string key) where T : class
        {
            cache.TryGetValue<T>(key, out T data);
            return data;
        }

        public T Set<T>(string key, T data) where T : class
        {
            if (data == null)
                return null;

            var field = data.GetType().GetProperty("Count");

            if ( field != null && (int)field.GetValue(data) == 0)
                return null;

            cache.Set<T>(key, data, cacheEntryOptions);

            return data;
        }

        public void Remove(string key)
            => cache.Remove(key);

        public void Clear()
            => cache.Dispose();
    }
}