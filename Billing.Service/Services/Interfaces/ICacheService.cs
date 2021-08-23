using System;
using System.Threading.Tasks;

namespace Billing.Service.Services.Interfaces
{
    public interface ICacheService
    {
        T Get<T>(string key) where T : class;

        T Set<T>(string key, T data) where T : class;

        void Remove(string key);

        void Clear();
    }
}