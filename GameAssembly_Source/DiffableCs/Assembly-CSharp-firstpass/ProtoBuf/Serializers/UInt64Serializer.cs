namespace ProtoBuf.Serializers;

internal sealed class UInt64Serializer : IProtoSerializer
{
	private static readonly Type expectedType; //Field offset: 0x2C927BC

	public override Type ExpectedType
	{
		 get { } //Length: 86
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.RequiresOldValue
	{
		private get { } //Length: 3
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.ReturnsValue
	{
		private get { } //Length: 3
	}

	private static UInt64Serializer() { }

	public UInt64Serializer(TypeModel model) { }

	public override Type get_ExpectedType() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter dest) { }

}

