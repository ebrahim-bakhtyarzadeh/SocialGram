using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain._Common.Exceptions.UserAggExceptions
{
    public class PhoneNumerIsNotValid : Exception
    {
        public PhoneNumerIsNotValid(string message) : base(message)
        {

        }

    }
}
