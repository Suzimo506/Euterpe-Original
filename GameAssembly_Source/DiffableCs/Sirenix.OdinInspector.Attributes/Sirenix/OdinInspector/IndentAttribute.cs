namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class IndentAttribute : Attribute
{
	public int IndentLevel; //Field offset: 0x10

	public IndentAttribute(int indentLevel = 1) { }

}

