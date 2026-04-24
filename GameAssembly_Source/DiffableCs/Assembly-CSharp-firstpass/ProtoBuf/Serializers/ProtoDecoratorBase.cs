namespace ProtoBuf.Serializers;

internal abstract class ProtoDecoratorBase : IProtoSerializer
{
	protected readonly IProtoSerializer Tail; //Field offset: 0x10

	public abstract Type ExpectedType
	{
		 get { } //Length: 0
	}

	public abstract bool RequiresOldValue
	{
		 get { } //Length: 0
	}

	public abstract bool ReturnsValue
	{
		 get { } //Length: 0
	}

	protected ProtoDecoratorBase(IProtoSerializer tail) { }

	public abstract Type get_ExpectedType() { }

	public abstract bool get_RequiresOldValue() { }

	public abstract bool get_ReturnsValue() { }

	public abstract object Read(object value, ProtoReader source) { }

	public abstract void Write(object value, ProtoWriter dest) { }

}

