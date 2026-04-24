namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class SuffixLabelAttribute : Attribute
{
	public string Label; //Field offset: 0x10
	public bool Overlay; //Field offset: 0x18

	public SuffixLabelAttribute(string label, bool overlay = false) { }

}

