namespace Newtonsoft.Json.Serialization;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IReferenceResolver
{

	public void AddReference(object context, string reference, object value) { }

	public string GetReference(object context, object value) { }

	public bool IsReferenced(object context, object value) { }

	public object ResolveReference(object context, string reference) { }

}

