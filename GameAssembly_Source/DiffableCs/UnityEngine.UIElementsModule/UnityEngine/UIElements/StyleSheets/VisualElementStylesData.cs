namespace UnityEngine.UIElements.StyleSheets;

internal class VisualElementStylesData
{
	private static StyleValuePropertyReader s_StyleValuePropertyReader; //Field offset: 0x0
	public static readonly VisualElementStylesData none; //Field offset: 0x8
	internal readonly bool isShared; //Field offset: 0x10
	internal StyleLength width; //Field offset: 0x14
	internal StyleLength height; //Field offset: 0x24
	internal StyleLength maxWidth; //Field offset: 0x34
	internal StyleLength maxHeight; //Field offset: 0x44
	internal StyleLength minWidth; //Field offset: 0x54
	internal StyleLength minHeight; //Field offset: 0x64
	internal StyleLength flexBasis; //Field offset: 0x74
	internal StyleFloat flexShrink; //Field offset: 0x84
	internal StyleFloat flexGrow; //Field offset: 0x90
	internal StyleInt overflow; //Field offset: 0x9C
	internal StyleLength left; //Field offset: 0xA8
	internal StyleLength top; //Field offset: 0xB8
	internal StyleLength right; //Field offset: 0xC8
	internal StyleLength bottom; //Field offset: 0xD8
	internal StyleInt alignSelf; //Field offset: 0xE8
	internal StyleColor color; //Field offset: 0xF4
	internal StyleColor unityBackgroundImageTintColor; //Field offset: 0x10C
	internal StyleInt alignItems; //Field offset: 0x124
	internal StyleInt alignContent; //Field offset: 0x130
	internal StyleColor borderLeftColor; //Field offset: 0x13C
	internal StyleColor borderTopColor; //Field offset: 0x154
	internal StyleColor borderRightColor; //Field offset: 0x16C
	internal StyleColor borderBottomColor; //Field offset: 0x184
	internal StyleFloat opacity; //Field offset: 0x19C
	internal StyleInt visibility; //Field offset: 0x1A8
	internal StyleInt display; //Field offset: 0x1B4
	internal float dpiScaling; //Field offset: 0x1C0

	private static VisualElementStylesData() { }

	public VisualElementStylesData(bool isShared) { }

}

