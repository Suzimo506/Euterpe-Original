namespace Newtonsoft.Json.Serialization;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IValueProvider
{

	public object GetValue(object target) { }

	public void SetValue(object target, object value) { }

}

