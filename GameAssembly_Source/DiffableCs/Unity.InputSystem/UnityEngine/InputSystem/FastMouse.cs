namespace UnityEngine.InputSystem;

internal class FastMouse : Mouse, IInputStateCallbackReceiver, IEventMerger
{
	public const string metadata = "AutoWindowSpace;Vector2;Button;Axis;Digital;Integer;Mouse;Pointer"; //Field offset: 0x0

	public FastMouse() { }

	private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	private Vector2Control Initialize_ctrlMousedelta(InternedString kVector2Layout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	private Vector2Control Initialize_ctrlMousescroll(InternedString kVector2Layout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	protected void OnNextUpdate() { }

	protected void OnStateEvent(InputEventPtr eventPtr) { }

	private override bool UnityEngine.InputSystem.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

