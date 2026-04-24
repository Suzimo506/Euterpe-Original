namespace UnityEngine.UIElements.StyleSheets;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal struct StyleValue
{
	public StylePropertyID id; //Field offset: 0x0
	public StyleKeyword keyword; //Field offset: 0x4
	public float number; //Field offset: 0x8
	public Length length; //Field offset: 0x8
	public Color color; //Field offset: 0x8
	public GCHandle resource; //Field offset: 0x8

	public static StyleValue Create(StylePropertyID id) { }

	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	public static StyleValue Create(StylePropertyID id, float number) { }

	public static StyleValue Create(StylePropertyID id, int number) { }

	public static StyleValue Create(StylePropertyID id, Color color) { }

}

