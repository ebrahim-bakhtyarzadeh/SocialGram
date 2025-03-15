using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SocialGram.Chat.Domain._Common.Bases
{
	public class BaseAggregate<TId>
	{
		public BaseAggregate()
		{
			CreationDate = DateTime.Now;
		}

		public TId Id { get; set; }
		public DateTime CreationDate { get; set; }
	}
}
