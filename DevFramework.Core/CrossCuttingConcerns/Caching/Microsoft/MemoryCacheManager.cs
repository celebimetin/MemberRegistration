using System;
using System.Runtime.Caching;
using System.Linq;
using System.Text.RegularExpressions;

namespace DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        protected ObjectCache Cache => MemoryCache.Default;

        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public void Add(string key, object data, int cacheTime = 60)
        {
            if (data == null)
            {
                return;
            }
            var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime) };
            Cache.Add(new CacheItem(key, data), policy);
        }

        public bool IsAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Romove(string key)
        {
            Cache.Remove(key);
        }

        public void RomoveByPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRomeve = Cache.Where(x => regex.IsMatch(x.Key)).Select(y => y.Key).ToList();

            foreach (var key in keysToRomeve)
            {
                Romove(key);
            }
        }

        public void Clear()
        {
            foreach (var item in Cache)
            {
                Romove(item.Key);
            }
        }
    }
}