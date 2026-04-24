namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonDynamicContract : JsonContainerContract
{
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Func<String, String> <PropertyNameResolver>k__BackingField; //Field offset: 0xC8
	private readonly ThreadSafeStore<String, CallSite`1<Func`3<CallSite, Object, Object>>> _callSiteGetters; //Field offset: 0xD0
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly ThreadSafeStore<String, CallSite`1<Func`4<CallSite, Object, Object, Object>>> _callSiteSetters; //Field offset: 0xD8

	public JsonPropertyCollection Properties
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Func<String, String> PropertyNameResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public JsonDynamicContract(Type underlyingType) { }

	private static CallSite<Func`3<CallSite, Object, Object>> CreateCallSiteGetter(string name) { }

	private static CallSite<Func`4<CallSite, Object, Object, Object>> CreateCallSiteSetter(string name) { }

	[CompilerGenerated]
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	public Func<String, String> get_PropertyNameResolver() { }

	[CompilerGenerated]
	public void set_PropertyNameResolver(Func<String, String> value) { }

	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

}

