namespace AmazonScraper.Service.Abstractions.Models.Scraping.ScrapeOps
{
    public class ScrapeOpsQuotaModel
    {
  public int RequestsUsed { get; set; }
      public int RequestsRemaining { get; set; }
        public int RequestLimit { get; set; }
    public DateTime ResetDate { get; set; }
    }
}