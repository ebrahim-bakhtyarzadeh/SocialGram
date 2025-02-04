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
		public TId Id { get; set; }




	}
	public abstract class BaseValueObject<TValueObject> : IEquatable<TValueObject> where TValueObject : BaseValueObject<TValueObject>
	{
		public bool Equals(TValueObject? other) => this == other;

		public abstract bool ObjectIsEqual(TValueObject other);

		public static bool operator ==(BaseValueObject<TValueObject> right, BaseValueObject<TValueObject> left)
		{
			if (ReferenceEquals(right, null) && ReferenceEquals(left, null))
				return true;
			if (ReferenceEquals(right, null) || ReferenceEquals(left, null))
				return false;
			return right.Equals(left);
		}
		public static bool operator != (BaseValueObject<TValueObject>right ,BaseValueObject<TValueObject> left )
		{
			return !(right == left);
		}
	}
}
