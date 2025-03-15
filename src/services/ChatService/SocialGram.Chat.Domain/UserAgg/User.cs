using SocialGram.Chat.Domain._Common.Bases;
using SocialGram.Chat.Domain._Common.Exceptions;
using SocialGram.Chat.Domain._Common.Exceptions.GlobalExceptions;
using SocialGram.Chat.Domain._Common.Exceptions.UserAggExceptions;
using SocialGram.Chat.Domain.ChatAgg.Entities;
using SocialGram.Chat.Domain.UserAgg.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain.UserAgg
{
	public class User : BaseAggregate<long>
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string AccountName { get; set; }
		public PhoneNumer PhoneNumber { get; private set; }
		public string? AboutMe { get; private set; }
		public string? Job { get; private set; }
		public List<ChatParticipant>Chats {  get;  set; }

		public User(string firstName, string lastName, string phoneNumber)
		{
			Guard(firstName, lastName);
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = new PhoneNumer(phoneNumber);
		}
		public void SetAboutMe(string aboutMe)
		{
			if (string.IsNullOrEmpty(aboutMe))
			{
				throw new NullOrEmptyDomainDateException("توضیحات کافی ای درباره ی خود وارد کنید ");
			}
			AboutMe = aboutMe;
		}
		public void SetJob(string job)
		{
			if (string.IsNullOrEmpty(job))
			{
				throw new NullOrEmptyDomainDateException("شغل خود را وارد کنید");
			}
			if (job.Length > 60)
			{
				throw new InvalidDomainDataException("شغل نمیتواند بیشتر از 60 کاراکتر داشته باشد");
			}

			Job = job;
		}

		private void Guard(string firstName, string lastName)
		{
			if (string.IsNullOrEmpty(firstName))
			{
				throw new FirstNameIsNotValid("وارد کردن نام ضروری است");
			}
			if (string.IsNullOrEmpty(lastName))
			{
				throw new LastNameIsNotValid("وارد کردن نام خانوادگی ضروری است");
			}

		}


	}
}
