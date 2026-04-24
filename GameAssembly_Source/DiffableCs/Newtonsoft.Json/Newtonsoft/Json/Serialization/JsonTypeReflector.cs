namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class JsonTypeReflector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static Func<Object, Type> <>9__22_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal Type <GetCreator>b__22_1(object param) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Type type; //Field offset: 0x10
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Func<Object> defaultConstructor; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal object <GetCreator>b__0(Object[] parameters) { }

	}

	private static Nullable<Boolean> _fullyTrusted; //Field offset: 0x0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static readonly ThreadSafeStore<Type, Func`2<Object[], Object>> CreatorCache; //Field offset: 0x8
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; //Field offset: 0x10
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; //Field offset: 0x18

	public static bool FullyTrusted
	{
		 get { } //Length: 276
	}

	public static ReflectionDelegateFactory ReflectionDelegateFactory
	{
		 get { } //Length: 153
	}

	private static JsonTypeReflector() { }

	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	public static JsonConverter CreateJsonConverterInstance(Type converterType, Object[] args) { }

	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, Object[] args) { }

	public static bool get_FullyTrusted() { }

	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	private static Type GetAssociatedMetadataType(Type type) { }

	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	public static T GetAttribute(object provider) { }

	private static T GetAttribute(MemberInfo memberInfo) { }

	private static T GetAttribute(Type type) { }

	public static T GetCachedAttribute(object attributeProvider) { }

	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	private static Func<Object[], Object> GetCreator(Type type) { }

	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	public static bool IsNonSerializable(object provider) { }

	public static bool IsSerializable(object provider) { }

}

