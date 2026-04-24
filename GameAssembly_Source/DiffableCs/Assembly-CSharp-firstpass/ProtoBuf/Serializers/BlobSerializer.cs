namespace ProtoBuf.Serializers;

internal sealed class BlobSerializer : IProtoSerializer
{
	private static readonly Type expectedType; //Field offset: 0x0
	private readonly bool overwriteList; //Field offset: 0x10

	public override Type ExpectedType
	{
		 get { } //Length: 86
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.RequiresOldValue
	{
		private get { } //Length: 8
	}

	private override bool ProtoBuf.Serializers.IProtoSerializer.ReturnsValue
	{
		private get { } //Length: 3
	}

	private static BlobSerializer() { }

	public BlobSerializer(TypeModel model, bool overwriteList) { }

	public override Type get_ExpectedType() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter dest) { }

}

