namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ButtonAttribute : ShowInInspectorAttribute
{
	public int ButtonHeight; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	public ButtonStyle Style; //Field offset: 0x20
	public bool Expanded; //Field offset: 0x24
	public bool DisplayParameters; //Field offset: 0x25
	public bool DirtyOnClick; //Field offset: 0x26
	private bool drawResult; //Field offset: 0x27
	private bool drawResultIsSet; //Field offset: 0x28

	public bool DrawResult
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool DrawResultIsSet
	{
		 get { } //Length: 5
	}

	public ButtonAttribute() { }

	public ButtonAttribute(ButtonSizes size) { }

	public ButtonAttribute(int buttonSize) { }

	public ButtonAttribute(string name) { }

	public ButtonAttribute(string name, ButtonSizes buttonSize) { }

	public ButtonAttribute(string name, int buttonSize) { }

	public ButtonAttribute(ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(string name, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle) { }

	public bool get_DrawResult() { }

	public bool get_DrawResultIsSet() { }

	public void set_DrawResult(bool value) { }

}

