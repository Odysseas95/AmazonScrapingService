using AmazonScraper.Service.Abstractions.Models;

namespace AmazonScraper.Service.Abstractions.Services.AmazonScraping
{
    /// <summary>
    /// Interface for gathering Amazon product information
  /// </summary>
  public interface IAmazonGatheringService
    {
        /// <summary>
     /// Gathers Amazon offers for a product
        /// </summary>
   Task<IEnumerable<AmazonOffer>> GatherOffersAsync(string asin, bool isAdhocRequest, Guid correlationId, CancellationToken cancellationToken = default);

        /// <summary>
     /// Gets seller name by ID
        /// </summary>
        Task<string> GetSellerNameAsync(string sellerId, CancellationToken cancellationToken = default);
    }
}