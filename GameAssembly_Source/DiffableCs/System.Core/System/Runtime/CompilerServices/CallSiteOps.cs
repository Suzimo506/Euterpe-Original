namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class CallSiteOps
{

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static void AddRule(CallSite<T> site, T rule) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static T Bind(CallSiteBinder binder, CallSite<T> site, Object[] args) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static void ClearMatch(CallSite site) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static CallSite<T> CreateMatchmaker(CallSite<T> site) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static T[] GetCachedRules(RuleCache<T> cache) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static bool GetMatch(CallSite site) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static RuleCache<T> GetRuleCache(CallSite<T> site) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static T[] GetRules(CallSite<T> site) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static void MoveRule(RuleCache<T> cache, T rule, int i) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static bool SetNotMatched(CallSite site) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static void UpdateRules(CallSite<T> this, int matched) { }

}

