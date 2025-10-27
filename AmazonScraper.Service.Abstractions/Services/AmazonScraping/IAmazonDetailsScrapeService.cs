using AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps;

namespace AmazonScraper.Service.Abstractions.Services.AmazonScraping
{
    /// <summary>
    /// Interface for scraping Amazon product details
    /// </summary>
    public interface IAmazonDetailsScrapeService
    {
        /// <summary>
        /// Gets Amazon product details
        /// </summary>
    Task<ExtractedAmazonProductModel> GetProductDetailsAsync(string asin, CancellationToken cancellationToken = default);

   /// <summary>
      /// Gets Amazon variant ratings
        /// </summary>
        Task<ExtractedAmazonVariantRatingsModel> GetVariantRatingsAsync(string asin, CancellationToken cancellationToken = default);
    }
}