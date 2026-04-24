namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class DefaultReferenceResolver : IReferenceResolver
{
	private int _referenceCount; //Field offset: 0x10

	public DefaultReferenceResolver() { }

	public override void AddReference(object context, string reference, object value) { }

	private BidirectionalDictionary<String, Object> GetMappings(object context) { }

	public override string GetReference(object context, object value) { }

	public override bool IsReferenced(object context, object value) { }

	public override object ResolveReference(object context, string reference) { }

}

