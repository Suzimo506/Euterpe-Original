namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ReflectionValueProvider : IValueProvider
{
	private readonly MemberInfo _memberInfo; //Field offset: 0x10

	public ReflectionValueProvider(MemberInfo memberInfo) { }

	public override object GetValue(object target) { }

	public override void SetValue(object target, object value) { }

}

