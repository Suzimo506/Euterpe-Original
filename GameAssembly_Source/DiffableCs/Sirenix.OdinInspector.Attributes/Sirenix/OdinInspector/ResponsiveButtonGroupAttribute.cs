namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IncludeMyAttributes]
[ShowInInspector]
public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute
{
	public ButtonSizes DefaultButtonSize; //Field offset: 0x38
	public bool UniformLayout; //Field offset: 0x3C

	public ResponsiveButtonGroupAttribute(string group = "_DefaultResponsiveButtonGroup") { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

