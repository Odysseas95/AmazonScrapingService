using System.Text.Json;

namespace AmazonScraper.Service.Helpers
{
    public static class JsonHelper
    {
/// <summary>
     /// Tries to deserialize JSON into a specified type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize into.</typeparam>
        /// <param name="json">The JSON string.</param>
   /// <param name="result">The resulting object if successful.</param>
     /// <returns>True if successful; otherwise, false.</returns>
        public static bool TryDeserialize<T>(string json, out T? result)
        {
        try
    {
    result = JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
    {
           PropertyNameCaseInsensitive = true
      });
         return result != null;
    }
        catch (JsonException)
  {
    // Handle invalid JSON format
result = default;
         return false;
         }
            catch (Exception)
         {
    // Handle other exceptions (optional)
  result = default;
       return false;
 }
     }

        /// <summary>
        /// Tries to deserialize Object into a specified type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize into.</typeparam>
     /// <param name="json">The JSON string.</param>
        /// <param name="result">The resulting object if successful.</param>
        /// <returns>True if successful; otherwise, false.</returns>
        public static bool TryDeserializeObject<T>(object objectVar, out T? result)
        {
            try
        {
                var json = JsonSerializer.Serialize(objectVar);

       result = JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
    {
          PropertyNameCaseInsensitive = true
                });
                return result != null;
        }
  catch (JsonException)
     {
    // Handle invalid JSON format
     result = default;
       return false;
       }
         catch (Exception)
    {
            // Handle other exceptions (optional)
  result = default;
          return false;
   }
 }
    }
}