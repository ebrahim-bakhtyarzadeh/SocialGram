namespace SocialGram.Chat.Domain._Common.Bases
{
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
