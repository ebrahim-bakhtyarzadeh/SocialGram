using SocialGram.Chat.Domain._Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain._Common.Validation
{
	public class CheckPhoneNumberPattern
	{
		public static bool CheckPatternOfPhoneNumber(string phoneNumber)
		{
			Regex regex = new Regex("[^09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}]");
			if (!regex.IsMatch(phoneNumber))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
