namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class MultiLinePropertyAttribute : Attribute
{
	public int Lines; //Field offset: 0x10

	public MultiLinePropertyAttribute(int lines = 3) { }

}

