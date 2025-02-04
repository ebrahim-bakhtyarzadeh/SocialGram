namespace SocialGram.Chat.Domain._Common.Exceptions.UserAggExceptions
{
    public class LastNameIsNotValid : Exception
    {
        public LastNameIsNotValid(string message) : base(message)
        {

        }
    }
}
