namespace ProtoBuf.Serializers;

internal sealed class UriDecorator : ProtoDecoratorBase
{
	private static readonly Type expectedType; //Field offset: 0x65110

	public virtual Type ExpectedType
	{
		 get { } //Length: 86
	}

	public virtual bool RequiresOldValue
	{
		 get { } //Length: 3
	}

	public virtual bool ReturnsValue
	{
		 get { } //Length: 3
	}

	private static UriDecorator() { }

	public UriDecorator(TypeModel model, IProtoSerializer tail) { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

