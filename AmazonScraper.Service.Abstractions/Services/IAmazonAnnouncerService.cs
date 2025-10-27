using AmazonScraper.Service.Abstractions.Models;

namespace AmazonScraper.Service.Abstractions.Services
{
    /// <summary>
    /// Interface for announcing Amazon offers to message bus
    /// </summary>
    public interface IAmazonAnnouncerService
  {
        /// <summary>
      /// Publishes Amazon offers to the message bus
     /// </summary>
  Task AnnounceOffersAsync(IEnumerable<AmazonOffer> amazonOffers, Guid correlationId);
}
}