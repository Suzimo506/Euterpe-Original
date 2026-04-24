namespace UnityEngine.UIElements;

public abstract class Focusable : CallbackEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <focusable>k__BackingField; //Field offset: 0x18
	internal bool isIMGUIContainer; //Field offset: 0x19

	public override bool canGrabFocus
	{
		 get { } //Length: 5
	}

	public bool focusable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
	}

	public override bool get_canGrabFocus() { }

	[CompilerGenerated]
	public bool get_focusable() { }

	public abstract FocusController get_focusController() { }

}

