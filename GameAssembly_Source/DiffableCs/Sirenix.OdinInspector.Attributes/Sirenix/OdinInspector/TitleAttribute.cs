namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public class TitleAttribute : Attribute
{
	public string Title; //Field offset: 0x10
	public string Subtitle; //Field offset: 0x18
	public bool Bold; //Field offset: 0x20
	public bool HorizontalLine; //Field offset: 0x21
	public TitleAlignments TitleAlignment; //Field offset: 0x24

	public TitleAttribute(string title, string subtitle = null, TitleAlignments titleAlignment = 0, bool horizontalLine = true, bool bold = true) { }

}

