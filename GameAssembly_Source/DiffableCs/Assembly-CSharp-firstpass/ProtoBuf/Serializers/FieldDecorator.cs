namespace ProtoBuf.Serializers;

internal sealed class FieldDecorator : ProtoDecoratorBase
{
	private readonly FieldInfo field; //Field offset: 0x18
	private readonly Type forType; //Field offset: 0x20

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

	public FieldDecorator(Type forType, FieldInfo field, IProtoSerializer tail) { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

