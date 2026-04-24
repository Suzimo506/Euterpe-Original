namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class JsonSerializerProxy : JsonSerializer
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly JsonSerializerInternalReader _serializerReader; //Field offset: 0xE0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly JsonSerializerInternalWriter _serializerWriter; //Field offset: 0xE8
	private readonly JsonSerializer _serializer; //Field offset: 0xF0

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual event EventHandler<ErrorEventArgs> Error
	{
		 add { } //Length: 42
		 remove { } //Length: 42
	}

	public virtual bool CheckAdditionalContent
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual ConstructorHandling ConstructorHandling
	{
		 set { } //Length: 42
	}

	public virtual StreamingContext Context
	{
		 get { } //Length: 62
		 set { } //Length: 55
	}

	public virtual IContractResolver ContractResolver
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual JsonConverterCollection Converters
	{
		 get { } //Length: 42
	}

	public virtual DefaultValueHandling DefaultValueHandling
	{
		 set { } //Length: 42
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IEqualityComparer EqualityComparer
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 42
	}

	public virtual Formatting Formatting
	{
		 get { } //Length: 42
	}

	public virtual MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual MissingMemberHandling MissingMemberHandling
	{
		 set { } //Length: 42
	}

	public virtual NullValueHandling NullValueHandling
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual ObjectCreationHandling ObjectCreationHandling
	{
		 set { } //Length: 42
	}

	public virtual PreserveReferencesHandling PreserveReferencesHandling
	{
		 set { } //Length: 42
	}

	public virtual ReferenceLoopHandling ReferenceLoopHandling
	{
		 set { } //Length: 42
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual IReferenceResolver ReferenceResolver
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 42
	}

	public virtual ISerializationBinder SerializationBinder
	{
		 set { } //Length: 42
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual ITraceWriter TraceWriter
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 42
	}

	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 set { } //Length: 42
	}

	public virtual TypeNameHandling TypeNameHandling
	{
		 set { } //Length: 42
	}

	public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter) { }

	public JsonSerializerProxy(JsonSerializerInternalReader serializerReader) { }

	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	public virtual bool get_CheckAdditionalContent() { }

	public virtual StreamingContext get_Context() { }

	public virtual IContractResolver get_ContractResolver() { }

	public virtual JsonConverterCollection get_Converters() { }

	public virtual Formatting get_Formatting() { }

	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public virtual NullValueHandling get_NullValueHandling() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual ITraceWriter get_TraceWriter() { }

	internal JsonSerializerInternalBase GetInternalSerializer() { }

	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

	public virtual void set_CheckAdditionalContent(bool value) { }

	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	public virtual void set_Context(StreamingContext value) { }

	public virtual void set_ContractResolver(IContractResolver value) { }

	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	public virtual void set_NullValueHandling(NullValueHandling value) { }

	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual void set_TraceWriter(ITraceWriter value) { }

	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

}

