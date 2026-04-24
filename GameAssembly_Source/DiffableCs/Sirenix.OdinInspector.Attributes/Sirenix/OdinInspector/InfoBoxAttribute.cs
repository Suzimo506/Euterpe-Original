namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class InfoBoxAttribute : Attribute
{
	public string Message; //Field offset: 0x10
	public InfoMessageType InfoMessageType; //Field offset: 0x18
	public string VisibleIf; //Field offset: 0x20
	public bool GUIAlwaysEnabled; //Field offset: 0x28

	public InfoBoxAttribute(string message, InfoMessageType infoMessageType = 1, string visibleIfMemberName = null) { }

	public InfoBoxAttribute(string message, string visibleIfMemberName) { }

}

