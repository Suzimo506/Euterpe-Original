namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public class LabelWidthAttribute : Attribute
{
	public float Width; //Field offset: 0x10

	public LabelWidthAttribute(float width) { }

}

