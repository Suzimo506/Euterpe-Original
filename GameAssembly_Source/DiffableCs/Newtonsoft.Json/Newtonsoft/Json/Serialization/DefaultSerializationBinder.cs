namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
{
	internal static readonly DefaultSerializationBinder Instance; //Field offset: 0x0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly ThreadSafeStore<StructMultiKey`2<String, String>, Type> _typeCache; //Field offset: 0x10

	private static DefaultSerializationBinder() { }

	public DefaultSerializationBinder() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public virtual Type BindToType(string assemblyName, string typeName) { }

	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	private Type GetTypeByName(StructMultiKey<String, String> typeNameKey) { }

	private Type GetTypeFromTypeNameKey(StructMultiKey<String, String> typeNameKey) { }

}

