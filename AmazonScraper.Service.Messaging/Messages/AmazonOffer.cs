namespace AmazonScraper.Service.Messaging.Messages
{
    public class AmazonOffer
    {
        public string Asin { get; set; }
        public AmazonOfferDetails OfferDetails { get; set; }
      public DateTime Timestamp { get; set; }
public Guid CorrelationId { get; set; }
    }
}