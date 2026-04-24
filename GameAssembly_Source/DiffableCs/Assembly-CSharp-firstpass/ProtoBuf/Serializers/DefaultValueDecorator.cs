namespace ProtoBuf.Serializers;

internal sealed class DefaultValueDecorator : ProtoDecoratorBase
{
	private readonly object defaultValue; //Field offset: 0x18

	public virtual Type ExpectedType
	{
		 get { } //Length: 69
	}

	public virtual bool RequiresOldValue
	{
		 get { } //Length: 72
	}

	public virtual bool ReturnsValue
	{
		 get { } //Length: 72
	}

	public DefaultValueDecorator(TypeModel model, object defaultValue, IProtoSerializer tail) { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

