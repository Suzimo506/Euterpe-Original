namespace UnityEngine.UIElements;

public class FocusController
{
	private struct FocusedElement
	{
		public VisualElement m_SubTreeRoot; //Field offset: 0x0
		public Focusable m_FocusedElement; //Field offset: 0x8

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly IFocusRing <focusRing>k__BackingField; //Field offset: 0x10
	private List<FocusedElement> m_FocusedElements; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <imguiKeyboardControl>k__BackingField; //Field offset: 0x20

	private IFocusRing focusRing
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	internal int imguiKeyboardControl
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	internal void DoFocusChange(Focusable f) { }

	[CompilerGenerated]
	private IFocusRing get_focusRing() { }

	[CompilerGenerated]
	internal int get_imguiKeyboardControl() { }

	internal Focusable GetLeafFocusedElement() { }

	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	[CompilerGenerated]
	internal void set_imguiKeyboardControl(int value) { }

	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

