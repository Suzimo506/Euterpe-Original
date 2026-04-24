namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class WrapAttribute : Attribute
{
	public double Min; //Field offset: 0x10
	public double Max; //Field offset: 0x18

	public WrapAttribute(double min, double max) { }

}

