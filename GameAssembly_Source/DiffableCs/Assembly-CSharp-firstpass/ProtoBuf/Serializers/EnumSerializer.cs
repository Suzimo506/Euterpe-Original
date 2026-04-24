namespace ProtoBuf.Serializers;

internal sealed class EnumSerializer : IProtoSerializer
{
	internal struct EnumPair
	{
		public readonly object RawValue; //Field offset: 0x0
		public readonly Enum TypedValue; //Field offset: 0x8
		public readonly int WireValue; //Field offset: 0x10

		public EnumPair(int wireValue, object raw, Type type) { }

	}

	private readonly Type enumType; //Field offset: 0x10
	private readonly EnumPair[] map; //Field offset: 0x18

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

	public EnumSerializer(Type enumType, EnumPair[] map) { }

	private int EnumToWire(object value) { }

	public override Type get_ExpectedType() { }

	private ProtoTypeCode GetTypeCode() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_RequiresOldValue() { }

	private override bool ProtoBuf.Serializers.IProtoSerializer.get_ReturnsValue() { }

	public override object Read(object value, ProtoReader source) { }

	private object WireToEnum(int value) { }

	public override void Write(object value, ProtoWriter dest) { }

}

