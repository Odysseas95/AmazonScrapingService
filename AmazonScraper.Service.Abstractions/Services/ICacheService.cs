namespace AmazonScraper.Service.Abstractions.Services
{
    /// <summary>
    /// Interface for caching operations with expiration support
    /// </summary>
 public interface ICacheService
    {
   /// <summary>
/// Gets a cached item by key or creates and caches it if not found
      /// </summary>
    Task<T> GetOrCreateAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration = null);

        /// <summary>
        /// Removes an item from cache by key
        /// </summary>
        void Remove(string key);

        /// <summary>
 /// Clears all items from the cache
        /// </summary>
        void Clear();
    }
}