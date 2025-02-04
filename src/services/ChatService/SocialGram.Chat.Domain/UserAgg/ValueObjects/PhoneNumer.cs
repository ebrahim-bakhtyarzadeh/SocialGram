using SocialGram.Chat.Domain._Common.Bases;

using SocialGram.Chat.Domain._Common.Exceptions.UserAggExceptions;
using SocialGram.Chat.Domain._Common.Validation;


namespace SocialGram.Chat.Domain.UserAgg.ValueObjects
{
	public class PhoneNumer : BaseValueObject<PhoneNumer>
	{
		public PhoneNumer(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new PhoneNumerIsNotValid("شماره تلفن وارد شده نمیتواند خالی باشد");
			}
			if (!CheckPhoneNumberPattern.CheckPatternOfPhoneNumber(value))
			{
				throw new PhoneNumerIsNotValid("شماره تلفن وارد شده معتبر نیست");
			}

			Value = value;
		}
		public string Value { get; private set; }


		public override bool ObjectIsEqual(PhoneNumer other) => this.Value == other.Value;

	}
}
