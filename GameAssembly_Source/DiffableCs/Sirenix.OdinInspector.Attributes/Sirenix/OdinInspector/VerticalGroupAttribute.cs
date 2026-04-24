namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VerticalGroupAttribute : PropertyGroupAttribute
{
	public float PaddingTop; //Field offset: 0x38
	public float PaddingBottom; //Field offset: 0x3C

	public VerticalGroupAttribute(string groupId, float order = 0) { }

	public VerticalGroupAttribute(float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

