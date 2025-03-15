using SocialGram.Chat.Domain._Common.Bases;
using SocialGram.Chat.Domain.ChatAgg.Entities;
using SocialGram.Chat.Domain.MessageAgg;
using SocialGram.Chat.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain.ChatAgg
{
	public class Chat : BaseAggregate<long>
	{
		public string? Name { get; set; }
		public ChatType Type { get; set; }
		public List<ChatParticipant> Participants { get; set; } = new();
		public List<Message> Messages { get; set; } = new();
		public Chat(int id, string? name, ChatType type)
		{
			Id = id;
			Name = name;
			Type = type;
		}
		public void AddParticipant(User user, ParticipantRole role)
		{
			if (Participants.Any(p => p.UserId == user.Id))
				throw new InvalidOperationException("کاربر در این گفتگو وجود دارد ");
			Participants.Add(new ChatParticipant(Id, user.Id, role));
		}
		public void SendMessage(Message message)
		{
			Messages.Add(message);
		}
	}

	public enum ChatType
	{
		Private,
		Group,
		Channel
	}



}
