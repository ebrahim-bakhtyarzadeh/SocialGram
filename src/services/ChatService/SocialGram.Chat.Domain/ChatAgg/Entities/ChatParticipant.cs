using SocialGram.Chat.Domain._Common.Bases;
using SocialGram.Chat.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain.ChatAgg.Entities
{
	public class ChatParticipant : BaseAggregate<long>
	{
		public long ChatId { get; set; }
		public Chat Chat { get; set; }
		public long UserId { get; set; }
		public User User { get; set; }
		public ParticipantRole Role { get; set; }
		public ChatParticipant(long chatId, long userId, ParticipantRole role)
		{
			ChatId = chatId;
			UserId = userId;
			Role = role;
		}

	}
	public enum ParticipantRole
	{
		Member,
		Admin,
		Owner
	}
}
