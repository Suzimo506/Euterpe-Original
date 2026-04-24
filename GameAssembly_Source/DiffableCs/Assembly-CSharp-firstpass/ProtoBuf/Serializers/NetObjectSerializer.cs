namespace ProtoBuf.Serializers;

internal sealed class NetObjectSerializer : IProtoSerializer
{
	private readonly int key; //Field offset: 0x10
	private readonly Type type; //Field offset: 0x18
	private readonly NetObjectOptions options; //Field offset: 0x20

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

	public NetObjectSerializer(TypeModel model, Type type, int key, NetObjectOptions options) { }

	public override Type get_ExpectedType() { }

	public override bool get_RequiresOldValue() { }

	public override bool get_ReturnsValue() { }

	public override object Read(object value, ProtoReader source) { }

	public override void Write(object value, ProtoWriter dest) { }

}

