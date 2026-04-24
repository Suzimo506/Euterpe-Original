namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal abstract class JsonSerializerInternalBase
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class ReferenceEqualsEqualityComparer : IEqualityComparer<Object>
	{

		public ReferenceEqualsEqualityComparer() { }

		private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

		private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ErrorContext _currentErrorContext; //Field offset: 0x10
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private BidirectionalDictionary<String, Object> _mappings; //Field offset: 0x18
	internal readonly JsonSerializer Serializer; //Field offset: 0x20
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal readonly ITraceWriter TraceWriter; //Field offset: 0x28
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected JsonSerializerProxy InternalSerializer; //Field offset: 0x30

	internal BidirectionalDictionary<String, Object> DefaultReferenceMappings
	{
		internal get { } //Length: 206
	}

	protected JsonSerializerInternalBase(JsonSerializer serializer) { }

	protected void ClearErrorContext() { }

	internal BidirectionalDictionary<String, Object> get_DefaultReferenceMappings() { }

	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

}

