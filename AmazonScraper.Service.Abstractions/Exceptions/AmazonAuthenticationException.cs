namespace AmazonScraper.Service.Abstractions.Exceptions
{
    public class AmazonAuthenticationException : AmazonException
    {
   public AmazonAuthenticationException() : base()
  {
        }

        public AmazonAuthenticationException(string message) : base(message)
    {
  }

        public AmazonAuthenticationException(string message, Exception innerException) 
     : base(message, innerException)
        {
   }
    }
}