namespace PeroTools2.Datas.Attributes;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VariableAttribute : Attribute
{
	public Type variableType; //Field offset: 0x10
	public Type valueType; //Field offset: 0x18
	public string methodName; //Field offset: 0x20
	public object defualtValue; //Field offset: 0x28
	public Type[] applyTypes; //Field offset: 0x30
	public bool hideArrow; //Field offset: 0x38

	public VariableAttribute(Type[] types) { }

	public VariableAttribute(Type type, string method = null, bool hide = false) { }

	public VariableAttribute(object value, string method = null, bool hide = false) { }

}

