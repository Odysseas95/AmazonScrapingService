using AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps;

namespace AmazonScraper.Service.Abstractions.Services.AmazonScraping.ScrapingTools
{
    /// <summary>
    /// Interface for ScrapeOps API operations
    /// </summary>
    public interface IScrapeOpsService
    {
        /// <summary>
        /// Gets a page using ScrapeOps proxy
        /// </summary>
        Task<string> GetPageAsync(string url, CancellationToken cancellationToken = default);

        /// <summary>
    /// Gets current ScrapeOps quota usage
        /// </summary>
        Task<ScrapeOpsQuotaModel> GetQuotaAsync(CancellationToken cancellationToken = default);
    }
}