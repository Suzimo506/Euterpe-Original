namespace UnityEngine.Rendering;

internal class DebugActionState
{
	private enum DebugActionKeyType
	{
		Button = 0,
		Axis = 1,
		Key = 2,
	}

	private DebugActionKeyType m_Type; //Field offset: 0x10
	private String[] m_PressedButtons; //Field offset: 0x18
	private string m_PressedAxis; //Field offset: 0x20
	private KeyCode[] m_PressedKeys; //Field offset: 0x28
	private Boolean[] m_TriggerPressedUp; //Field offset: 0x30
	private float m_Timer; //Field offset: 0x38
	[CompilerGenerated]
	private bool <runningAction>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <actionState>k__BackingField; //Field offset: 0x40

	internal float actionState
	{
		[CompilerGenerated]
		internal get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	internal bool runningAction
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DebugActionState() { }

	[CompilerGenerated]
	internal float get_actionState() { }

	[CompilerGenerated]
	internal bool get_runningAction() { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_actionState(float value) { }

	[CompilerGenerated]
	private void set_runningAction(bool value) { }

	private void Trigger(int triggerCount, float state) { }

	public void TriggerWithAxis(string axis, float state) { }

	public void TriggerWithButton(String[] buttons, float state) { }

	public void TriggerWithKey(KeyCode[] keys, float state) { }

	public void Update(DebugActionDesc desc) { }

}

