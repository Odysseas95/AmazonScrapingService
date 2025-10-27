namespace AmazonScraper.Service.Abstractions.Services
{
    /// <summary>
    /// Interface for tracking application metrics and telemetry
    /// </summary>
    public interface IMetricsService
    {
        /// <summary>
      /// Tracks a custom event with properties and metrics
        /// </summary>
      void TrackEvent(string eventName, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null);
    }
}