namespace AmazonScraper.Service.Abstractions.Configuration
{
    public class RetryPolicyConfiguration
    {
        public int MaxRetryAttempts { get; set; }
        public TimeSpan BaseDelay { get; set; }
        public TimeSpan MaxDelay { get; set; }
    }
}