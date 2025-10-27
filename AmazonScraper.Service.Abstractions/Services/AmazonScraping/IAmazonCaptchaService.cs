namespace AmazonScraper.Service.Abstractions.Services.AmazonScraping
{
    /// <summary>
    /// Interface for handling Amazon CAPTCHA challenges
    /// </summary>
    public interface IAmazonCaptchaService
    {
 /// <summary>
   /// Solves Amazon CAPTCHA using external service
     /// </summary>
        Task<string> SolveCaptchaAsync(string captchaKey, CancellationToken cancellationToken = default);
    }
}