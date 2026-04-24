namespace Rewired.Utils.Attributes;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[CustomClassObfuscation]
[CustomObfuscation]
public class SerializationTypeAttribute : Attribute
{
	internal enum SerializationType
	{
		Default = 0,
		Object = 1,
	}

	private SerializationType _serializationType; //Field offset: 0x10

	public SerializationType serializationType
	{
		 get { } //Length: 4
	}

	public SerializationTypeAttribute(SerializationType unnamed_param_0) { }

	public SerializationType get_serializationType() { }

}

