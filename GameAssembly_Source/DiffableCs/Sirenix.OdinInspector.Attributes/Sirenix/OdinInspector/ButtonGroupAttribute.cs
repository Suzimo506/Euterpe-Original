namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IncludeMyAttributes]
[ShowInInspector]
public class ButtonGroupAttribute : PropertyGroupAttribute
{

	public ButtonGroupAttribute(string group = "_DefaultGroup", float order = 0) { }

}

