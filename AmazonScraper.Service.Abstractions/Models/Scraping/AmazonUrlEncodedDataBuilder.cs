using System.Web;

namespace AmazonScraper.Service.Abstractions.Models.Scraping
{
    public class AmazonUrlEncodedDataBuilder
    {
        private readonly Dictionary<string, string> _parameters = new();

        public AmazonUrlEncodedDataBuilder Add(string key, string value)
     {
            _parameters[key] = value;
         return this;
 }

        public string Build()
        {
            return string.Join("&", _parameters.Select(p => $"{HttpUtility.UrlEncode(p.Key)}={HttpUtility.UrlEncode(p.Value)}"));
        }
    }
}