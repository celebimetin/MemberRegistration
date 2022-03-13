namespace DevFramework.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        void Add(string key, object data, int cacheTime);

        bool IsAdd(string key);

        void Romove(string key);

        void RomoveByPattern(string pattern);

        void Clear();
    }
}