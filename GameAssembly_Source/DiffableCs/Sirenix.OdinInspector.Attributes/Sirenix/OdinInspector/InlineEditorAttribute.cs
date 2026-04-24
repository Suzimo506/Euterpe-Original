namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class InlineEditorAttribute : Attribute
{
	private bool expanded; //Field offset: 0x10
	public bool DrawHeader; //Field offset: 0x11
	public bool DrawGUI; //Field offset: 0x12
	public bool DrawPreview; //Field offset: 0x13
	public float MaxHeight; //Field offset: 0x14
	public float PreviewWidth; //Field offset: 0x18
	public float PreviewHeight; //Field offset: 0x1C
	public bool IncrementInlineEditorDrawerDepth; //Field offset: 0x20
	public InlineEditorObjectFieldModes ObjectFieldMode; //Field offset: 0x24
	public bool DisableGUIForVCSLockedAssets; //Field offset: 0x28
	[CompilerGenerated]
	private bool <ExpandedHasValue>k__BackingField; //Field offset: 0x29

	public bool Expanded
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public private bool ExpandedHasValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public InlineEditorAttribute(InlineEditorModes inlineEditorMode = 0, InlineEditorObjectFieldModes objectFieldMode = 0) { }

	public InlineEditorAttribute(InlineEditorObjectFieldModes objectFieldMode) { }

	public bool get_Expanded() { }

	[CompilerGenerated]
	public bool get_ExpandedHasValue() { }

	public void set_Expanded(bool value) { }

	[CompilerGenerated]
	private void set_ExpandedHasValue(bool value) { }

}

