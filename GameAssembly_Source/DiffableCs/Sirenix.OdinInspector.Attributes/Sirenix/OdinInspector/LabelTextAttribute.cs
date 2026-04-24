namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public class LabelTextAttribute : Attribute
{
	public string Text; //Field offset: 0x10
	public bool NicifyText; //Field offset: 0x18

	public LabelTextAttribute(string text) { }

	public LabelTextAttribute(string text, bool nicifyText) { }

}

