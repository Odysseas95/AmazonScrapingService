namespace AmazonScraper.Service.Abstractions.Configuration
{
    public class AmazonScrapeConfiguration
    {
        public ScrapeOps ScrapeOps { get; set; }
      public Playwright Playwright { get; set; }
 public int MaxOfferPageStock { get; set; }
        public ScrapeAttributes ScrapeAttributes { get; set; }
        public string ResiliencePipeline { get; set; }
        public int AsinOfferCachingTimeMins { get; set; }
    }

    public class ScrapeOps
    {
        public bool ScrapeOpsEnabled { get; set; }
    public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public string BackendBaseUrl { get; set; }
    }

    public class Playwright
    {
      public bool PlaywrightEnabled { get; set; }
        public int MaxSiteRefreshes { get; set; }
    public int SiteRefreshWaitMs { get; set; }
        public int PageLoadTimeoutMs { get; set; }
        public int CartWidgetIncrementDelayMs { get; set; }
        public bool UseHeadlessBrowser { get; set; }
    }

    public class ScrapeAttributes
    {
        public string BaseUrl { get; set; }
      public string ProductPageUrl { get; set; }
        public string GetOffersPageUrl { get; set; }
        public string RatingsInfoBaseUrl { get; set; }
 public string SellerNameUrl { get; set; }
        public string AddToCartSelector { get; set; }
        public string QuantityDropdownSelector { get; set; }
  public string Quantity10Selector { get; set; }
        public string QuantityInputSelector { get; set; }
     public string IncreaseCartQuantitySelector { get; set; }
        public string PopupSelector { get; set; }
 public string PopupStockRegex { get; set; }
    public string CaptchaKeySelector { get; set; }
        public string DismissButtonSelector { get; set; }
        public string QuantityWidgetSelector { get; set; }
  public string IncrementButtonSelector { get; set; }
        public string QuantityBoxSelector { get; set; }
        public string ErrorPageSelector { get; set; }
        public string AmazonAssosciateTag { get; set; }
        public string LocationZipCode { get; set; }
   public string CartEmptySelector { get; set; }
        public string ItemUnavailableSelector { get; set; }
    }
}