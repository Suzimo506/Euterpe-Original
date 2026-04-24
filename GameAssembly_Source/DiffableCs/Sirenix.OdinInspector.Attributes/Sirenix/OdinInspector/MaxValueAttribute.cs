namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class MaxValueAttribute : Attribute
{
	public double MaxValue; //Field offset: 0x10
	public string Expression; //Field offset: 0x18

	public MaxValueAttribute(double maxValue) { }

	public MaxValueAttribute(string expression) { }

}

