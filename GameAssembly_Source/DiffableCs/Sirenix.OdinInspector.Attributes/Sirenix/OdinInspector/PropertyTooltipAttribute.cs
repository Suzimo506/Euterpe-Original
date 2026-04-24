namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class PropertyTooltipAttribute : Attribute
{
	public string Tooltip; //Field offset: 0x10

	public PropertyTooltipAttribute(string tooltip) { }

}

