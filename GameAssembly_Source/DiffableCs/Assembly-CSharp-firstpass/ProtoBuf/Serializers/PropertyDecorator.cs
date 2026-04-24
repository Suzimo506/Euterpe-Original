namespace ProtoBuf.Serializers;

internal sealed class PropertyDecorator : ProtoDecoratorBase
{
	private readonly PropertyInfo property; //Field offset: 0x18
	private readonly Type forType; //Field offset: 0x20
	private readonly bool readOptionsWriteValue; //Field offset: 0x28
	private readonly MethodInfo shadowSetter; //Field offset: 0x30

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

	public PropertyDecorator(TypeModel model, Type forType, PropertyInfo property, IProtoSerializer tail) { }

	internal static bool CanWrite(TypeModel model, MemberInfo member) { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	private static MethodInfo GetShadowSetter(TypeModel model, PropertyInfo property) { }

	public virtual object Read(object value, ProtoReader source) { }

	private static void SanityCheck(TypeModel model, PropertyInfo property, IProtoSerializer tail, out bool writeValue, bool nonPublic, bool allowInternal) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

