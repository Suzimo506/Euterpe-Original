namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class MinValueAttribute : Attribute
{
	public double MinValue; //Field offset: 0x10
	public string Expression; //Field offset: 0x18

	public MinValueAttribute(double minValue) { }

	public MinValueAttribute(string expression) { }

}

