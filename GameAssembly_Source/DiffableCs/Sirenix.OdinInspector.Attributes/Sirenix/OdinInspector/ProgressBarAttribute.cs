namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProgressBarAttribute : Attribute
{
	public double Min; //Field offset: 0x10
	public double Max; //Field offset: 0x18
	public string MinGetter; //Field offset: 0x20
	public string MaxGetter; //Field offset: 0x28
	public float R; //Field offset: 0x30
	public float G; //Field offset: 0x34
	public float B; //Field offset: 0x38
	public int Height; //Field offset: 0x3C
	public string ColorGetter; //Field offset: 0x40
	public string BackgroundColorGetter; //Field offset: 0x48
	public bool Segmented; //Field offset: 0x50
	public string CustomValueStringGetter; //Field offset: 0x58
	private bool drawValueLabel; //Field offset: 0x60
	private TextAlignment valueLabelAlignment; //Field offset: 0x64
	[CompilerGenerated]
	private bool <DrawValueLabelHasValue>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <ValueLabelAlignmentHasValue>k__BackingField; //Field offset: 0x69

	[Obsolete]
	public string BackgroundColorMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Color Color
	{
		 get { } //Length: 67
	}

	[Obsolete]
	public string ColorMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[Obsolete]
	public string CustomValueStringMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public bool DrawValueLabel
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public private bool DrawValueLabelHasValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[Obsolete]
	public string MaxMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[Obsolete]
	public string MinMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public TextAlignment ValueLabelAlignment
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public private bool ValueLabelAlignmentHasValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ProgressBarAttribute(string minGetter, double max, float r = 0.15, float g = 0.47, float b = 0.74) { }

	public ProgressBarAttribute(string minGetter, string maxGetter, float r = 0.15, float g = 0.47, float b = 0.74) { }

	public ProgressBarAttribute(double min, string maxGetter, float r = 0.15, float g = 0.47, float b = 0.74) { }

	public ProgressBarAttribute(double min, double max, float r = 0.15, float g = 0.47, float b = 0.74) { }

	public string get_BackgroundColorMember() { }

	public Color get_Color() { }

	public string get_ColorMember() { }

	public string get_CustomValueStringMember() { }

	public bool get_DrawValueLabel() { }

	[CompilerGenerated]
	public bool get_DrawValueLabelHasValue() { }

	public string get_MaxMember() { }

	public string get_MinMember() { }

	public TextAlignment get_ValueLabelAlignment() { }

	[CompilerGenerated]
	public bool get_ValueLabelAlignmentHasValue() { }

	public void set_BackgroundColorMember(string value) { }

	public void set_ColorMember(string value) { }

	public void set_CustomValueStringMember(string value) { }

	public void set_DrawValueLabel(bool value) { }

	[CompilerGenerated]
	private void set_DrawValueLabelHasValue(bool value) { }

	public void set_MaxMember(string value) { }

	public void set_MinMember(string value) { }

	public void set_ValueLabelAlignment(TextAlignment value) { }

	[CompilerGenerated]
	private void set_ValueLabelAlignmentHasValue(bool value) { }

}

