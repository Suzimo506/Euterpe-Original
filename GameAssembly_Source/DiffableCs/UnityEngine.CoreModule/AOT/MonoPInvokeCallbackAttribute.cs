namespace AOT;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MonoPInvokeCallbackAttribute : Attribute
{

	public MonoPInvokeCallbackAttribute(Type type) { }

}

