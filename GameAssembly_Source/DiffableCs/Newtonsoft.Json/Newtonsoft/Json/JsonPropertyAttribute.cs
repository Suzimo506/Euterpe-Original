namespace Newtonsoft.Json;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class JsonPropertyAttribute : Attribute
{
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0x30
	internal Nullable<Boolean> _isReference; //Field offset: 0x38
	internal Nullable<Int32> _order; //Field offset: 0x3C
	internal Nullable<Required> _required; //Field offset: 0x44
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Object[] <NamingStrategyParameters>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; //Field offset: 0x80

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Object[] ItemConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type ItemConverterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Object[] NamingStrategyParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type NamingStrategyType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string PropertyName
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public JsonPropertyAttribute() { }

	[CompilerGenerated]
	public Object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	public Object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	public string get_PropertyName() { }

}

