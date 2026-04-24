namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class DynamicUtils
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static class BinderWrapper
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static object _getCSharpArgumentInfoArray; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static object _setCSharpArgumentInfoArray; //Field offset: 0x8
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static MethodCall<Object, Object> _getMemberCall; //Field offset: 0x10
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private static MethodCall<Object, Object> _setMemberCall; //Field offset: 0x18
		private static bool _init; //Field offset: 0x20

		private static void CreateMemberCalls() { }

		private static object CreateSharpArgumentInfoArray(Int32[] values) { }

		public static CallSiteBinder GetMember(string name, Type context) { }

		private static void Init() { }

		public static CallSiteBinder SetMember(string name, Type context) { }

	}


	[Extension]
	public static IEnumerable<String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

