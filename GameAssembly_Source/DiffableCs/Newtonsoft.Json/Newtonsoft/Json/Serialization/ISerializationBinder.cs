namespace Newtonsoft.Json.Serialization;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface ISerializationBinder
{

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public Type BindToType(string assemblyName, string typeName) { }

}

