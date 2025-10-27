using AmazonScraper.Service.Abstractions.Models.Scraping;

namespace AmazonScraper.Service.Abstractions.Services.AmazonScraping.ScrapingTools
{
    /// <summary>
 /// Interface for Playwright browser automation operations
    /// </summary>
    public interface IAmazonPlaywrightService
    {
        /// <summary>
        /// Gets a page using Playwright browser
        /// </summary>
        Task<string> GetPageAsync(string url, CancellationToken cancellationToken = default);

        /// <summary>
      /// Handles Amazon cart operations using Playwright
        /// </summary>
        Task<AmazonCartModel> HandleCartAsync(AmazonAddToCartModel addToCartModel, CancellationToken cancellationToken = default);
    }
}