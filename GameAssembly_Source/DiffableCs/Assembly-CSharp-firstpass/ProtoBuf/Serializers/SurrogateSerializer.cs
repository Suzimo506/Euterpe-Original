namespace ProtoBuf.Serializers;

internal sealed class SurrogateSerializer : IProtoTypeSerializer, IProtoSerializer
{
	private readonly Type forType; //Field offset: 0x10
	private readonly Type declaredType; //Field offset: 0x18
	private readonly MethodInfo toTail; //Field offset: 0x20
	private readonly MethodInfo fromTail; //Field offset: 0x28
	private IProtoTypeSerializer rootTail; //Field offset: 0x30

	public override Type ExpectedType
	{
		 get { } //Length: 5
	}

	public override bool RequiresOldValue
	{
		 get { } //Length: 3
	}

	public override bool ReturnsValue
	{
		 get { } //Length: 3
	}

	public SurrogateSerializer(TypeModel model, Type forType, Type declaredType, IProtoTypeSerializer rootTail) { }

	public override Type get_ExpectedType() { }

	public override bool get_RequiresOldValue() { }

	public override bool get_ReturnsValue() { }

	public MethodInfo GetConversion(TypeModel model, bool toTail) { }

	private static bool HasCast(TypeModel model, Type type, Type from, Type to, out MethodInfo op) { }

	private override void ProtoBuf.Serializers.IProtoTypeSerializer.Callback(object value, CallbackType callbackType, SerializationContext context) { }

	private override bool ProtoBuf.Serializers.IProtoTypeSerializer.CanCreateInstance() { }

	private override object ProtoBuf.Serializers.IProtoTypeSerializer.CreateInstance(ProtoReader source) { }

	private override bool ProtoBuf.Serializers.IProtoTypeSerializer.HasCallbacks(CallbackType callbackType) { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter writer) { }

}

