namespace ProtoBuf.Serializers;

internal interface IProtoTypeSerializer : IProtoSerializer
{

	public void Callback(object value, CallbackType callbackType, SerializationContext context) { }

	public bool CanCreateInstance() { }

	public object CreateInstance(ProtoReader source) { }

	public bool HasCallbacks(CallbackType callbackType) { }

}

