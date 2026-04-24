namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class NoThrowGetBinderMember : GetMemberBinder
{
	private readonly GetMemberBinder _innerBinder; //Field offset: 0x28

	public NoThrowGetBinderMember(GetMemberBinder innerBinder) { }

	public virtual DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

