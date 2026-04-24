namespace ProtoBuf.Serializers;

internal sealed class ParseableSerializer : IProtoSerializer
{
	private readonly MethodInfo parse; //Field offset: 0x10

	public override Type ExpectedType
	{
		 get { } //Length: 39
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.RequiresOldValue
	{
		private get { } //Length: 3
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.ReturnsValue
	{
		private get { } //Length: 3
	}

	private ParseableSerializer(MethodInfo parse) { }

	public override Type get_ExpectedType() { }

	private static MethodInfo GetCustomToString(Type type) { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	public override object Read(object value, ProtoReader source) { }

	public static ParseableSerializer TryCreate(Type type, TypeModel model) { }

	public override void Write(object value, ProtoWriter dest) { }

}

