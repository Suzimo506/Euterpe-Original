namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Obsolete]
public class CustomFormatterAttribute : Attribute
{
	public readonly int Priority; //Field offset: 0x10

	public CustomFormatterAttribute() { }

	public CustomFormatterAttribute(int priority = 0) { }

}

