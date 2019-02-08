using System;
using System.Threading.Tasks;

namespace RoomTemp.Domain
{
    public interface ICachingService
    {
        Task<T> GetCachedValue<T>(string key, Func<Task<T>> func, TimeSpan expireIn, Func<T, bool> shouldCacheResult = null);

        T GetCachedValue<T>(string key, Func<T> func, TimeSpan expireIn, Func<T, bool> shouldCacheResult = null);
        
        void ResetCache(string key);
    }
}