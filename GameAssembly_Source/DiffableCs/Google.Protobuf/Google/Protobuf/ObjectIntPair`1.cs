namespace Google.Protobuf;

internal struct ObjectIntPair : IEquatable<ObjectIntPair`1<T>>
{
	private readonly int number; //Field offset: 0x0
	private readonly T obj; //Field offset: 0x0

	internal ObjectIntPair`1(T obj, int number) { }

	public override bool Equals(ObjectIntPair<T> other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

