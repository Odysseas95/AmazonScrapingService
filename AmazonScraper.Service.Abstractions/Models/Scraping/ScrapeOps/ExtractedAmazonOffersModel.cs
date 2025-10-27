namespace AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps
{
    public class ExtractedAmazonOffersModel
    {
        public List<AmazonOffer> Offers { get; set; } = new();
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
    public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}