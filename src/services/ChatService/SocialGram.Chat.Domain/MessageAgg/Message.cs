using SocialGram.Chat.Domain._Common.Exceptions.GlobalExceptions;
using SocialGram.Chat.Domain.UserAgg;


namespace SocialGram.Chat.Domain.MessageAgg
{
   public class Message
    {
		public long Id { get; set; }
		public long ChatId { get; set; }
		public long SenderId { get; set; }
		public string Content { get; set; } = string.Empty;
		public List<Reaction> _reactions { get; set; } = new();

		public long? ReplyToMessageId { get; set; }
		public Message? ReplyToMessage { get; set; }


		public Message(int chatId, int senderId, string content, Message? replyToMessage = null)
		{
			ChatId = chatId;
			SenderId = senderId;
			Content = content;
			ReplyToMessage = replyToMessage;
		}

		public void AddReaction( string emoji)
		{
			if (string.IsNullOrEmpty (emoji))
			{
				return;
			}
			_reactions.Add(new Reaction( emoji));
		}
	}
	public class Reaction
	{
		public long Id { get; set; }
		public long MessageId { get; set; }
		
		public string Emoji { get; set; } = string.Empty;

		public Reaction( string emoji)
		{
			
			Emoji = emoji;
		}
	}
}
