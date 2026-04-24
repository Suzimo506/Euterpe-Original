namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ToggleAttribute : Attribute
{
	public string ToggleMemberName; //Field offset: 0x10
	public bool CollapseOthersOnExpand; //Field offset: 0x18

	public ToggleAttribute(string toggleMemberName) { }

}

