namespace ProtoBuf.Serializers;

internal sealed class TypeSerializer : IProtoTypeSerializer, IProtoSerializer
{
	private static readonly Type iextensible; //Field offset: 0x0
	private readonly Type forType; //Field offset: 0x10
	private readonly Type constructType; //Field offset: 0x18
	private readonly IProtoSerializer[] serializers; //Field offset: 0x20
	private readonly Int32[] fieldNumbers; //Field offset: 0x28
	private readonly bool isRootType; //Field offset: 0x30
	private readonly bool useConstructor; //Field offset: 0x31
	private readonly bool isExtensible; //Field offset: 0x32
	private readonly bool hasConstructor; //Field offset: 0x33
	private readonly CallbackSet callbacks; //Field offset: 0x38
	private readonly MethodInfo[] baseCtorCallbacks; //Field offset: 0x40
	private readonly MethodInfo factory; //Field offset: 0x48

	private bool CanHaveInheritance
	{
		private get { } //Length: 87
	}

	public override Type ExpectedType
	{
		 get { } //Length: 5
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.RequiresOldValue
	{
		private get { } //Length: 3
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.ReturnsValue
	{
		private get { } //Length: 3
	}

	private static TypeSerializer() { }

	public TypeSerializer(TypeModel model, Type forType, Int32[] fieldNumbers, IProtoSerializer[] serializers, MethodInfo[] baseCtorCallbacks, bool isRootType, bool useConstructor, CallbackSet callbacks, Type constructType, MethodInfo factory) { }

	public override void Callback(object value, CallbackType callbackType, SerializationContext context) { }

	private object CreateInstance(ProtoReader source, bool includeLocalCallback) { }

	private bool get_CanHaveInheritance() { }

	public override Type get_ExpectedType() { }

	private IProtoSerializer GetMoreSpecificSerializer(object value) { }

	public override bool HasCallbacks(CallbackType callbackType) { }

	private object InvokeCallback(MethodInfo method, object obj, SerializationContext context) { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	private override bool ProtoBuf.Serializers.IProtoTypeSerializer.CanCreateInstance() { }

	private override object ProtoBuf.Serializers.IProtoTypeSerializer.CreateInstance(ProtoReader source) { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter dest) { }

}

