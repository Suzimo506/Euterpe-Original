namespace ProtoBuf.Serializers;

internal interface IProtoSerializer
{

	public Type ExpectedType
	{
		 get { } //Length: 0
	}

	public bool RequiresOldValue
	{
		 get { } //Length: 0
	}

	public bool ReturnsValue
	{
		 get { } //Length: 0
	}

	public Type get_ExpectedType() { }

	public bool get_RequiresOldValue() { }

	public bool get_ReturnsValue() { }

	public object Read(object value, ProtoReader source) { }

	public void Write(object value, ProtoWriter dest) { }

}

