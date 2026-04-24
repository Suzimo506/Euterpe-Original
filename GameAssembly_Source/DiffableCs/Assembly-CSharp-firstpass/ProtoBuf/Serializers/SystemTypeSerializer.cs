namespace ProtoBuf.Serializers;

internal sealed class SystemTypeSerializer : IProtoSerializer
{
	private static readonly Type expectedType; //Field offset: 0x650AE

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

	private static SystemTypeSerializer() { }

	public SystemTypeSerializer(TypeModel model) { }

	public override Type get_ExpectedType() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	private override object ProtoBuf.Serializers.IProtoSerializer.Read(object value, ProtoReader source) { }

	private override void ProtoBuf.Serializers.IProtoSerializer.Write(object value, ProtoWriter dest) { }

}

