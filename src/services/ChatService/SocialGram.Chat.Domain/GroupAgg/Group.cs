using SocialGram.Chat.Domain._Common.Bases;
using SocialGram.Chat.Domain._Common.Exceptions.GlobalExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain.GroupAgg
{
	public class Group : BaseAggregate<long>
	{
		public string GroupName { get; private set; }
		public string? Description { get; private set; }
		public long OwnerId { get; private set; }

		public Group(string groupName, long ownerId)
		{

			GroupName = groupName;
			OwnerId = ownerId;
		}
		public void SetDescription(string description)
		{
			if (string.IsNullOrEmpty(description))
			{
				throw new NullOrEmptyDomainDateException("توضیحات گروه نمیتواند خالی باشد");
			}
			Description = description;
		}
		private void Guard(string groupName, long OwnerId)
		{
			if (string.IsNullOrEmpty(groupName))
			{
				throw new NullOrEmptyDomainDateException("وارد کردن نام گروه ضروری است");
			}
			if (OwnerId == 0)
			{
				throw new NullOrEmptyDomainDateException("شناسه سازنده گروه نامعتبر است");
			}
		}

		// relation to chat message

	}

	public 
}
