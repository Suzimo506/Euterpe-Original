namespace ProtoBuf.Serializers;

internal sealed class NullDecorator : ProtoDecoratorBase
{
	public const int Tag = 1; //Field offset: 0x0
	private readonly Type expectedType; //Field offset: 0x18

	public virtual Type ExpectedType
	{
		 get { } //Length: 5
	}

	public virtual bool RequiresOldValue
	{
		 get { } //Length: 3
	}

	public virtual bool ReturnsValue
	{
		 get { } //Length: 3
	}

	public NullDecorator(TypeModel model, IProtoSerializer tail) { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

