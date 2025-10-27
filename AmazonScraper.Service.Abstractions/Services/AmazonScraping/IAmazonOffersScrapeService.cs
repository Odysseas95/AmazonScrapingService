using AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps;

namespace AmazonScraper.Service.Abstractions.Services.AmazonScraping
{
    /// <summary>
    /// Interface for scraping Amazon product offers
    /// </summary>
    public interface IAmazonOffersScrapeService
    {
        /// <summary>
    /// Gets Amazon product offers
        /// </summary>
        Task<ExtractedAmazonOffersModel> GetOffersAsync(string asin, CancellationToken cancellationToken = default);
    }
}