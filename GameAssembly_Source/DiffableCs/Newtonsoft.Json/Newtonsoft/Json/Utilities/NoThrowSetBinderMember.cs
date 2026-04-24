namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class NoThrowSetBinderMember : SetMemberBinder
{
	private readonly SetMemberBinder _innerBinder; //Field offset: 0x28

	public NoThrowSetBinderMember(SetMemberBinder innerBinder) { }

	public virtual DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

