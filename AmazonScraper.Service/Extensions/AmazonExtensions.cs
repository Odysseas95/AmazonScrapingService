using System.Globalization;

namespace AmazonScraper.Service.Extensions
{
    public static class AmazonExtensions
    {
        public static string ParseSellerAsinFromLink(this string sellerUrl)
  {
     var sellerSubstring = sellerUrl.Substring(sellerUrl.IndexOf("seller"));
  var startIndex = sellerSubstring.IndexOf("=");
   var endIndex = sellerSubstring.IndexOf("&");
     var asin = sellerSubstring.Substring(startIndex + 1, endIndex - startIndex - 1);
    return asin;
   }

        public static decimal ParseCurrency(this string currencyString)
        {
      return decimal.Parse(currencyString.Substring(1).Split()[0], CultureInfo.InvariantCulture);
 }

        public static int ParsePositiveRatingsPercent(this string ratingString)
        {
 try
     {
   string[] ratingSubstrings = ratingString.Split("@@");
   return int.Parse(ratingSubstrings.First(s => s.Contains("%")).Split('%').First());
      }
         catch (Exception ex)
     {
      return -1;
  }
        }

      public static int ParseRatingsCount(this string ratingString)
        {
  try
   {
 var ratingSubstrings = ratingString.Split("@@").Where(s => !s.Contains('%') && s.Contains(' '));

  if (!ratingSubstrings.Any())
        return -1;

       return int.Parse(ratingSubstrings.First().Split(' ').First().Replace("(", "").Replace(")", ""));
        }
            catch (Exception ex)
    {
    return -1;
   }
        }

    public static string ParseRatingsPeriod(this string ratingString)
        {
       try
       {
       var index = ratingString.IndexOf("%");
    return ratingString.Substring(index + 1).TrimStart();
      }
            catch (Exception)
  {
            return null;
     }
  }
    }
}