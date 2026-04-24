namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TypeInfoBoxAttribute : Attribute
{
	public string Message; //Field offset: 0x10

	public TypeInfoBoxAttribute(string message) { }

}

