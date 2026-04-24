namespace ProtoBuf.Serializers;

internal interface ISerializerProxy
{

	public IProtoSerializer Serializer
	{
		 get { } //Length: 0
	}

	public IProtoSerializer get_Serializer() { }

}

