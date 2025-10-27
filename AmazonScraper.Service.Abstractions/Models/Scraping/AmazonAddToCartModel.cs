namespace AmazonScraper.Service.Abstractions.Models.Scraping
{
    public class AmazonAddToCartModel
    {
        public string Url { get; set; }
        public int Quantity { get; set; }
  public bool HandleCaptcha { get; set; }
    }
}