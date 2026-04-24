namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class DisableContextMenuAttribute : Attribute
{
	public bool DisableForMember; //Field offset: 0x10
	public bool DisableForCollectionElements; //Field offset: 0x11

	public DisableContextMenuAttribute(bool disableForMember = true, bool disableCollectionElements = false) { }

}

