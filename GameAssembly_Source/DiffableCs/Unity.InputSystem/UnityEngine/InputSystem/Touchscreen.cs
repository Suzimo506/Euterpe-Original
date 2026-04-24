namespace UnityEngine.InputSystem;

[InputControlLayout]
public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger
{
	[CompilerGenerated]
	private static Touchscreen <current>k__BackingField; //Field offset: 0x0
	internal static float s_TapTime; //Field offset: 0x8
	internal static float s_TapDelayTime; //Field offset: 0xC
	internal static float s_TapRadiusSquared; //Field offset: 0x10
	[CompilerGenerated]
	private TouchControl <primaryTouch>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private ReadOnlyArray<TouchControl> <touches>k__BackingField; //Field offset: 0x188

	public internal static Touchscreen current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		internal set { } //Length: 66
	}

	public TouchControl primaryTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	protected TouchControl[] touchControlArray
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public ReadOnlyArray<TouchControl> touches
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Touchscreen() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static Touchscreen get_current() { }

	[CompilerGenerated]
	public TouchControl get_primaryTouch() { }

	protected TouchControl[] get_touchControlArray() { }

	[CompilerGenerated]
	public ReadOnlyArray<TouchControl> get_touches() { }

	public virtual void MakeCurrent() { }

	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	protected void OnNextUpdate() { }

	protected virtual void OnRemoved() { }

	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CompilerGenerated]
	internal static void set_current(Touchscreen value) { }

	[CompilerGenerated]
	protected void set_primaryTouch(TouchControl value) { }

	protected void set_touchControlArray(TouchControl[] value) { }

	[CompilerGenerated]
	protected void set_touches(ReadOnlyArray<TouchControl> value) { }

	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	private override bool UnityEngine.InputSystem.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

