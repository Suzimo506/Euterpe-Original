namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class ImmutableCollectionsUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static Func<MethodInfo, Boolean> <>9__24_1; //Field offset: 0x8
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static Func<MethodInfo, Boolean> <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string name; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string name; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public class ImmutableCollectionTypeInfo
	{
		[CompilerGenerated]
		private string <ContractTypeName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <CreatedTypeName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <BuilderTypeName>k__BackingField; //Field offset: 0x20

		public string BuilderTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public string ContractTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public string CreatedTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName) { }

		[CompilerGenerated]
		public string get_BuilderTypeName() { }

		[CompilerGenerated]
		public string get_ContractTypeName() { }

		[CompilerGenerated]
		public string get_CreatedTypeName() { }

		[CompilerGenerated]
		public void set_BuilderTypeName(string value) { }

		[CompilerGenerated]
		public void set_ContractTypeName(string value) { }

		[CompilerGenerated]
		public void set_CreatedTypeName(string value) { }

	}

	private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; //Field offset: 0x0
	private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; //Field offset: 0x8

	private static ImmutableCollectionsUtils() { }

	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

}

