namespace AmazonScraper.Service.Abstractions.Configuration
{
    public class SecretsConfiguration
    {
        public string ScrapeOpsApiKey { get; set; }
        public string PostgresUser { get; set; }
        public string PostgresPassword { get; set; }
 public string MessagingPassword { get; set; }
    }
}