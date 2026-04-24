namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public class PropertySpaceAttribute : Attribute
{
	public float SpaceBefore; //Field offset: 0x10
	public float SpaceAfter; //Field offset: 0x14

	public PropertySpaceAttribute() { }

	public PropertySpaceAttribute(float spaceBefore) { }

	public PropertySpaceAttribute(float spaceBefore, float spaceAfter) { }

}

