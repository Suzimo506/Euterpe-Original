namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonProperty
{
	internal Nullable<Required> _required; //Field offset: 0x10
	internal bool _hasExplicitDefaultValue; //Field offset: 0x18
	private object _defaultValue; //Field offset: 0x20
	private bool _hasGeneratedDefaultValue; //Field offset: 0x28
	private string _propertyName; //Field offset: 0x30
	internal bool _skipPropertyNameEscape; //Field offset: 0x38
	private Type _propertyType; //Field offset: 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Nullable<Int32> <Order>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; //Field offset: 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; //Field offset: 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; //Field offset: 0x83
	[CompilerGenerated]
	private Nullable<Boolean> <IsReference>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Predicate<Object> <ShouldSerialize>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Predicate<Object> <ShouldDeserialize>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Predicate<Object> <GetIsSpecified>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<Object, Object> <SetIsSpecified>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Nullable<Boolean> <ItemIsReference>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; //Field offset: 0xE4

	public IAttributeProvider AttributeProvider
	{
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public JsonConverter Converter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Type DeclaringType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public object DefaultValue
	{
		 get { } //Length: 14
		 set { } //Length: 16
	}

	public Nullable<DefaultValueHandling> DefaultValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Predicate<Object> GetIsSpecified
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public bool HasMemberAttribute
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool Ignored
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Nullable<Boolean> IsReference
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public JsonConverter ItemConverter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Nullable<Boolean> ItemIsReference
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<TypeNameHandling> ItemTypeNameHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<NullValueHandling> NullValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<ObjectCreationHandling> ObjectCreationHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Int32> Order
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	internal JsonContract PropertyContract
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public string PropertyName
	{
		 get { } //Length: 5
		 set { } //Length: 154
	}

	public Type PropertyType
	{
		 get { } //Length: 5
		 set { } //Length: 146
	}

	public bool Readable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Required Required
	{
		 get { } //Length: 54
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Action<Object, Object> SetIsSpecified
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Predicate<Object> ShouldDeserialize
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Predicate<Object> ShouldSerialize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Nullable<TypeNameHandling> TypeNameHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string UnderlyingName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public IValueProvider ValueProvider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool Writable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public JsonProperty() { }

	[CompilerGenerated]
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	public Type get_DeclaringType() { }

	public object get_DefaultValue() { }

	[CompilerGenerated]
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	public Predicate<Object> get_GetIsSpecified() { }

	[CompilerGenerated]
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	public bool get_Ignored() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_IsReference() { }

	[CompilerGenerated]
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_ItemIsReference() { }

	[CompilerGenerated]
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	public Nullable<Int32> get_Order() { }

	[CompilerGenerated]
	internal JsonContract get_PropertyContract() { }

	public string get_PropertyName() { }

	public Type get_PropertyType() { }

	[CompilerGenerated]
	public bool get_Readable() { }

	[CompilerGenerated]
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	public Required get_Required() { }

	[CompilerGenerated]
	public Action<Object, Object> get_SetIsSpecified() { }

	[CompilerGenerated]
	public Predicate<Object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	public Predicate<Object> get_ShouldSerialize() { }

	[CompilerGenerated]
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	public bool get_Writable() { }

	internal object GetResolvedDefaultValue() { }

	[CompilerGenerated]
	public void set_AttributeProvider(IAttributeProvider value) { }

	[CompilerGenerated]
	public void set_Converter(JsonConverter value) { }

	[CompilerGenerated]
	public void set_DeclaringType(Type value) { }

	public void set_DefaultValue(object value) { }

	[CompilerGenerated]
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	public void set_GetIsSpecified(Predicate<Object> value) { }

	[CompilerGenerated]
	public void set_HasMemberAttribute(bool value) { }

	[CompilerGenerated]
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	public void set_IsReference(Nullable<Boolean> value) { }

	[CompilerGenerated]
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	public void set_ItemIsReference(Nullable<Boolean> value) { }

	[CompilerGenerated]
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	public void set_Order(Nullable<Int32> value) { }

	[CompilerGenerated]
	internal void set_PropertyContract(JsonContract value) { }

	public void set_PropertyName(string value) { }

	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	public void set_SetIsSpecified(Action<Object, Object> value) { }

	[CompilerGenerated]
	public void set_ShouldSerialize(Predicate<Object> value) { }

	[CompilerGenerated]
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	public void set_Writable(bool value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string ToString() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void WritePropertyName(JsonWriter writer) { }

}

