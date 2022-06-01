using System;
using Billing.Service.Data;
using Billing.Service.Services.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace Billing.Service.Services.Implementations
{
    public class CacheService : ICacheService
    {
        public CacheService(CacheContext context)
        {
            this.context = context;
        }

        private CacheContext context;

        public T Get<T>(string key) where T : class
        {
            return context.Get<T>(key);
        }

        public T Set<T>(string key, T data) where T : class
        {
            return context.Set<T>(key, data);
        }

        public void Remove(string key)
        {
            context.Remove(key);
        }

        public void Clear()
        {
            context.Clear();
        }
    }
}