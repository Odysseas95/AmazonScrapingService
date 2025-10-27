using Polly;

namespace AmazonScraper.Service.Abstractions.Services
{
    /// <summary>
    /// Interface for configuring and managing retry policies
    /// </summary>
    public interface IRetryPolicyService
    {
        /// <summary>
        /// Gets a retry policy with exponential backoff
        /// </summary>
        ResiliencePipeline GetResiliencePipeline(string pipelineName);

        /// <summary>
        /// Gets a retry policy with exponential backoff for HTTP operations
    /// </summary>
     ResiliencePipeline<HttpResponseMessage> GetHttpResiliencePipeline(string pipelineName);
    }
}