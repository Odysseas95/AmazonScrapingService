using AmazonScraper.Service.Abstractions.Services;
using Microsoft.ApplicationInsights;

namespace AmazonScraper.Service.Services
{
    /// <summary>
    /// Service for tracking application metrics and telemetry data using Azure Application Insights.
/// Provides a centralized interface for logging performance metrics, custom events, and operational data.
    /// </summary>
    /// <remarks>
    /// This service is thread-safe and optimized for high-frequency telemetry operations.
    /// All telemetry data is automatically batched and transmitted to Application Insights.
    /// </remarks>
    public class MetricsService : IMetricsService
    {
        private readonly TelemetryClient _telemetryClient;

        /// <summary>
        /// Initializes a new instance of the MetricsService.
        /// </summary>
     /// <param name="telemetryClient">Azure Application Insights telemetry client for data transmission</param>
        /// <exception cref="ArgumentNullException">Thrown when telemetryClient is null</exception>
 public MetricsService(TelemetryClient telemetryClient)
  {
            _telemetryClient = telemetryClient ?? throw new ArgumentNullException(nameof(telemetryClient));
        }

        /// <summary>
        /// Tracks a custom event with optional properties and metrics for monitoring and analytics.
   /// Events are asynchronously transmitted to Application Insights with automatic batching.
   /// </summary>
        /// <param name="eventName">Name of the event to track (e.g., "GetPageScrapeOpsTime", "OfferProcessed")</param>
        /// <param name="properties">Optional dictionary of string properties for additional context</param>
      /// <param name="metrics">Optional dictionary of numeric metrics for performance data</param>
        /// <exception cref="ArgumentNullException">Thrown when eventName is null</exception>
     /// <exception cref="ArgumentException">Thrown when eventName is empty or whitespace</exception>
        /// <example>
        /// <code>
   /// // Track performance metrics
        /// metricsService.TrackEvent("GetPageScrapeOpsTime", 
        ///   properties: new Dictionary&lt;string, string&gt; { { "asin", "B123456789" } },
    ///     metrics: new Dictionary&lt;string, double&gt; { { "milliseconds", 1250.5 } });
   /// 
   /// // Track business events
  /// metricsService.TrackEvent("OfferProcessed", 
   ///     properties: new Dictionary&lt;string, string&gt; { { "seller", "Amazon.com" } });
        /// </code>
   /// </example>
        /// <remarks>
  /// This method is thread-safe and non-blocking. Telemetry data is queued for transmission.
        /// Large property or metric collections may impact performance; consider batching for high-volume scenarios.
        /// Events are automatically enriched with standard telemetry properties like timestamp and session info.
        /// </remarks>
        public void TrackEvent(string eventName, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null)
        {
            if (eventName == null)
         throw new ArgumentNullException(nameof(eventName));
        
          if (string.IsNullOrWhiteSpace(eventName))
          throw new ArgumentException("Event name cannot be empty or whitespace.", nameof(eventName));

         _telemetryClient.TrackEvent(eventName, properties, metrics);
        }
    }
}