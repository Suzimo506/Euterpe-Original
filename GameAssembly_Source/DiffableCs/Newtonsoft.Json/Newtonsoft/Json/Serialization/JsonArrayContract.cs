namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonArrayContract : JsonContainerContract
{
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; //Field offset: 0xC8
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0xD0
	private Type _genericWrapperType; //Field offset: 0xD8
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ObjectConstructor<Object> _genericWrapperCreator; //Field offset: 0xE0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Func<Object> _genericTemporaryCollectionCreator; //Field offset: 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; //Field offset: 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0xF8
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x100
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x110

	internal bool CanDeserialize
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Type CollectionItemType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool HasParameterizedCreator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	internal bool HasParameterizedCreatorInternal
	{
		internal get { } //Length: 118
	}

	internal bool IsArray
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public bool IsMultidimensionalArray
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ObjectConstructor<Object> OverrideCreator
	{
		 get { } //Length: 8
		 set { } //Length: 37
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		internal get { } //Length: 232
	}

	internal bool ShouldCreateWrapper
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public JsonArrayContract(Type underlyingType) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal IList CreateTemporaryCollection() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal IWrappedCollection CreateWrapper(object list) { }

	[CompilerGenerated]
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	public bool get_HasParameterizedCreator() { }

	internal bool get_HasParameterizedCreatorInternal() { }

	[CompilerGenerated]
	internal bool get_IsArray() { }

	[CompilerGenerated]
	public bool get_IsMultidimensionalArray() { }

	public ObjectConstructor<Object> get_OverrideCreator() { }

	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CompilerGenerated]
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	private void set_CanDeserialize(bool value) { }

	[CompilerGenerated]
	public void set_HasParameterizedCreator(bool value) { }

	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }

}

