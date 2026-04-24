namespace ProtoBuf.Serializers;

internal sealed class CharSerializer : UInt16Serializer
{
	private static readonly Type expectedType; //Field offset: 0x2C927B4

	public virtual Type ExpectedType
	{
		 get { } //Length: 86
	}

	private static CharSerializer() { }

	public CharSerializer(TypeModel model) { }

	public virtual Type get_ExpectedType() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

