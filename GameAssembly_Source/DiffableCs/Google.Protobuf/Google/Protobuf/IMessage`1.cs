namespace Google.Protobuf;

public interface IMessage : IMessage, IEquatable<T>, IDeepCloneable<T>
{

	public void MergeFrom(T message) { }

}

