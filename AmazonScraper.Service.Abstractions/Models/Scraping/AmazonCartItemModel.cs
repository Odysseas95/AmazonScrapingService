namespace AmazonScraper.Service.Abstractions.Models.Scraping
{
    public class AmazonCartItemModel
    {
        public string Asin { get; set; }
      public int Quantity { get; set; }
        public int MaxQuantity { get; set; }
   public bool IsQuantityLimited { get; set; }
  public string ErrorMessage { get; set; }
    }
}