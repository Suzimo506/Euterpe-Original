namespace ProtoBuf.Serializers;

internal sealed class SubItemSerializer : IProtoTypeSerializer, IProtoSerializer
{
	private readonly int key; //Field offset: 0x10
	private readonly Type type; //Field offset: 0x18
	private readonly ISerializerProxy proxy; //Field offset: 0x20
	private readonly bool recursionCheck; //Field offset: 0x28

	private override Type ProtoBuf.Serializers.IProtoSerializer.ExpectedType
	{
		private get { } //Length: 5
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.RequiresOldValue
	{
		private get { } //Length: 3
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.ReturnsValue
	{
		private get { } //Length: 3
	}

	public SubItemSerializer(Type type, int key, ISerializerProxy proxy, bool recursionCheck) { }

	private override Type ProtoBuf.Serializers.IProtoSerializer.get_ExpectedType() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	private override object ProtoBuf.Serializers.IProtoSerializer.Read(object value, ProtoReader source) { }

	private override void ProtoBuf.Serializers.IProtoSerializer.Write(object value, ProtoWriter dest) { }

	private override void ProtoBuf.Serializers.IProtoTypeSerializer.Callback(object value, CallbackType callbackType, SerializationContext context) { }

	private override bool ProtoBuf.Serializers.IProtoTypeSerializer.CanCreateInstance() { }

	private override object ProtoBuf.Serializers.IProtoTypeSerializer.CreateInstance(ProtoReader source) { }

	private override bool ProtoBuf.Serializers.IProtoTypeSerializer.HasCallbacks(CallbackType callbackType) { }

}

