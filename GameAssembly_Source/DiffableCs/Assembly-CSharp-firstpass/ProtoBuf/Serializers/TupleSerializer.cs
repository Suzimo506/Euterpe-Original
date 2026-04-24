namespace ProtoBuf.Serializers;

internal sealed class TupleSerializer : IProtoTypeSerializer, IProtoSerializer
{
	private readonly MemberInfo[] members; //Field offset: 0x10
	private readonly ConstructorInfo ctor; //Field offset: 0x18
	private IProtoSerializer[] tails; //Field offset: 0x20

	public override Type ExpectedType
	{
		 get { } //Length: 39
	}

	public override bool RequiresOldValue
	{
		 get { } //Length: 3
	}

	public override bool ReturnsValue
	{
		 get { } //Length: 3
	}

	public TupleSerializer(RuntimeTypeModel model, ConstructorInfo ctor, MemberInfo[] members) { }

	public override Type get_ExpectedType() { }

	public override bool get_RequiresOldValue() { }

	public override bool get_ReturnsValue() { }

	private Type GetMemberType(int index) { }

	private object GetValue(object obj, int index) { }

	public override bool HasCallbacks(CallbackType callbackType) { }

	private override void ProtoBuf.Serializers.IProtoTypeSerializer.Callback(object value, CallbackType callbackType, SerializationContext context) { }

	private override bool ProtoBuf.Serializers.IProtoTypeSerializer.CanCreateInstance() { }

	private override object ProtoBuf.Serializers.IProtoTypeSerializer.CreateInstance(ProtoReader source) { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter dest) { }

}

