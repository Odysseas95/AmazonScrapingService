using AmazonScraper.Service.Abstractions.Services;
using AmazonScraper.Service.Messaging.Messages;
using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace AmazonScraper.Service.Services
{
  /// <summary>
  /// Service responsible for publishing Amazon offer messages to the message bus.
    /// Handles transformation and publishing of offer data to notify downstream systems.
    /// </summary>
    public class AmazonAnnouncerService : IAmazonAnnouncerService
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ILogger<AmazonAnnouncerService> _logger;
    private readonly IMapper _mapper;

  /// <summary>
        /// Initializes a new instance of the AmazonAnnouncerService.
     /// </summary>
    /// <param name="publishEndpoint">MassTransit publish endpoint for message publishing</param>
        /// <param name="logger">Logger for tracking service operations</param>
  /// <param name="mapper">AutoMapper for transforming offer objects</param>
        /// <exception cref="ArgumentNullException">Thrown when any required parameter is null</exception>
  public AmazonAnnouncerService(
  IPublishEndpoint publishEndpoint,
       ILogger<AmazonAnnouncerService> logger,
    IMapper mapper)
        {
 _publishEndpoint = publishEndpoint;
  _logger = logger;
       _mapper = mapper;
    }

        /// <summary>
        /// Publishes Amazon offers to the message bus for downstream processing.
        /// Each offer is published as an individual message with correlation tracking.
        /// </summary>
        /// <param name="amazonOffers">Collection of Amazon offers to publish</param>
 /// <param name="correlationId">Unique identifier for tracking related operations</param>
        /// <returns>Task representing the asynchronous operation</returns>
        /// <exception cref="ArgumentNullException">Thrown when amazonOffers is null</exception>
        /// <exception cref="InvalidOperationException">Thrown when message publishing fails</exception>
 public async Task AnnounceOffersAsync(IEnumerable<Abstractions.Models.AmazonOffer> amazonOffers, Guid correlationId)
        {
     try
          {
       foreach (var offer in amazonOffers)
      {
    await _publishEndpoint.Publish(new AmazonOffer
    {
  Asin = offer.ProductAsin,
      OfferDetails = _mapper.Map<AmazonOfferDetails>(offer),
          Timestamp = DateTime.UtcNow,
 CorrelationId = correlationId
        });
     }

   _logger.LogInformation("Successfully published all offers for asin: {Asin}",
      amazonOffers.FirstOrDefault()?.ProductAsin);
         }
            catch (Exception ex)
            {
_logger.LogError(ex, "Failed to announce offer. Asin: {Asin}",
           amazonOffers.FirstOrDefault()?.ProductAsin);
      throw;
       }
        }
    }
}