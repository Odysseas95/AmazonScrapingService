namespace AmazonScraper.Service.Abstractions.Models
{
    public class AmazonOffer
    {
public string ProductAsin { get; set; }
        public decimal Price { get; set; }
        public string ShipType { get; set; }
     public string SellerName { get; set; }
    public string Condition { get; set; }
        public string DeliveryDate { get; set; }
        public int Stock { get; set; }
    }
}