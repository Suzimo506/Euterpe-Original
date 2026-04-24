namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TitleGroupAttribute : PropertyGroupAttribute
{
	public string Subtitle; //Field offset: 0x38
	public TitleAlignments Alignment; //Field offset: 0x40
	public bool HorizontalLine; //Field offset: 0x44
	public bool BoldTitle; //Field offset: 0x45
	public bool Indent; //Field offset: 0x46

	public TitleGroupAttribute(string title, string subtitle = null, TitleAlignments alignment = 0, bool horizontalLine = true, bool boldTitle = true, bool indent = false, float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

