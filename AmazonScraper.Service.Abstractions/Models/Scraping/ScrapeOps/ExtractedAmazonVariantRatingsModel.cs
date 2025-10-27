namespace AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps
{
    public class ExtractedAmazonVariantRatingsModel
    {
    public int PositiveRatingsPercent { get; set; }
        public int RatingsCount { get; set; }
   public string RatingsPeriod { get; set; }
  public bool IsSuccess { get; set; }
     public string ErrorMessage { get; set; }
 }
}