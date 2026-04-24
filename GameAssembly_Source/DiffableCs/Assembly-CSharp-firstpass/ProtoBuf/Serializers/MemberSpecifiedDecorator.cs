namespace ProtoBuf.Serializers;

internal sealed class MemberSpecifiedDecorator : ProtoDecoratorBase
{
	private readonly MethodInfo getSpecified; //Field offset: 0x18
	private readonly MethodInfo setSpecified; //Field offset: 0x20

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

	public MemberSpecifiedDecorator(MethodInfo getSpecified, MethodInfo setSpecified, IProtoSerializer tail) { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

