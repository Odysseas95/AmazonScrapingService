namespace AmazonScraper.Service.Abstractions.Models.Scraping
{
    public class AmazonCartModel
    {
   public List<AmazonCartItemModel> Items { get; set; } = new();
  public bool IsSuccess { get; set; }
   public string ErrorMessage { get; set; }
    }
}