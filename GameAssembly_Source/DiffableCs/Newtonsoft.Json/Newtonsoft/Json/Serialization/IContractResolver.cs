namespace Newtonsoft.Json.Serialization;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IContractResolver
{

	public JsonContract ResolveContract(Type type) { }

}

