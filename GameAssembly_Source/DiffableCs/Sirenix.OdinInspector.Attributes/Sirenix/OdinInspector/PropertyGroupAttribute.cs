namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class PropertyGroupAttribute : Attribute
{
	public string GroupID; //Field offset: 0x10
	public string GroupName; //Field offset: 0x18
	public float Order; //Field offset: 0x20
	public bool HideWhenChildrenAreInvisible; //Field offset: 0x24
	public string VisibleIf; //Field offset: 0x28
	public bool AnimateVisibility; //Field offset: 0x30

	public PropertyGroupAttribute(string groupId, float order) { }

	public PropertyGroupAttribute(string groupId) { }

	public PropertyGroupAttribute Combine(PropertyGroupAttribute other) { }

	protected override void CombineValuesWith(PropertyGroupAttribute other) { }

}

