namespace SocialGram.Chat.Domain._Common.Exceptions.GlobalExceptions
{
    public class NullOrEmptyDomainDateException : Exception
    {
        public NullOrEmptyDomainDateException(string message) : base(message)
        {

        }

    }
    public class InvalidDomainDataException : Exception
    {
        public InvalidDomainDataException(string message):base(message) 
        {
               
        }
    }
}
