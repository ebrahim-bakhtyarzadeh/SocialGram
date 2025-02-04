namespace SocialGram.Chat.Domain._Common.Exceptions.UserAggExceptions
{
    public class FirstNameIsNotValid : Exception
    {
        public FirstNameIsNotValid(string message) : base(message)
        {

        }
    }
}
