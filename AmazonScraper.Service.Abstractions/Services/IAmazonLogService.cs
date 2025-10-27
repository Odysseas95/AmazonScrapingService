using AmazonScraper.Service.Abstractions.Models;

namespace AmazonScraper.Service.Abstractions.Services
{
  /// <summary>
    /// Interface for logging Amazon service operations
    /// </summary>
    public interface IAmazonLogService
    {
        /// <summary>
        /// Logs a request with correlation tracking
  /// </summary>
        Task LogRequestAsync(string triggerFlow, string amazonMarketplace, string asin, bool isAdhocRequest, Guid correlationId, string metadata = null);

        /// <summary>
        /// Logs a response with correlation tracking
        /// </summary>
        Task LogResponseAsync(bool isSuccess, string resultPayload, Guid correlationId);

        /// <summary>
  /// Logs a scraping action with correlation tracking
        /// </summary>
     Task LogScrapeActionAsync(string amazonUrl, string actionType, string scrapeActionPayload, Guid correlationId, string metadata = null);
    }
}