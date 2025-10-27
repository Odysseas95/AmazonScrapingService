namespace AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps
{
    public class ExtractedAmazonProductModel
    {
        public string Name { get; set; }
     public string Brand { get; set; }
        public string Category { get; set; }
    public string Description { get; set; }
    public List<string> Features { get; set; }
        public string Pricing { get; set; }
  public string AvailabilityStatus { get; set; }
        public Dictionary<string, string> TechnicalDetails { get; set; }
      public List<string> ImageUrls { get; set; }
    }
}