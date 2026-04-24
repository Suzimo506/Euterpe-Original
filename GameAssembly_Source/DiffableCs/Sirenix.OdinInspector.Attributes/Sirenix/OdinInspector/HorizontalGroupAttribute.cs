namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class HorizontalGroupAttribute : PropertyGroupAttribute
{
	public float Width; //Field offset: 0x38
	public float MarginLeft; //Field offset: 0x3C
	public float MarginRight; //Field offset: 0x40
	public float PaddingLeft; //Field offset: 0x44
	public float PaddingRight; //Field offset: 0x48
	public float MinWidth; //Field offset: 0x4C
	public float MaxWidth; //Field offset: 0x50
	public string Title; //Field offset: 0x58
	public float LabelWidth; //Field offset: 0x60

	public HorizontalGroupAttribute(string group, float width = 0, int marginLeft = 0, int marginRight = 0, float order = 0) { }

	public HorizontalGroupAttribute(float width = 0, int marginLeft = 0, int marginRight = 0, float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

