namespace ProtoBuf.Serializers;

internal sealed class BooleanSerializer : IProtoSerializer
{
	private static readonly Type expectedType; //Field offset: 0x64F30

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

	private static BooleanSerializer() { }

	public BooleanSerializer(TypeModel model) { }

	public override Type get_ExpectedType() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter dest) { }

}

