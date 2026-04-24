namespace UnityEngine.InputSystem;

[InputControlLayout]
public class StepCounter : Sensor
{
	[CompilerGenerated]
	private static StepCounter <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private IntegerControl <stepCounter>k__BackingField; //Field offset: 0x158

	public private static StepCounter current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	[InputControl]
	public private IntegerControl stepCounter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public StepCounter() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static StepCounter get_current() { }

	[CompilerGenerated]
	public IntegerControl get_stepCounter() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(StepCounter value) { }

	[CompilerGenerated]
	private void set_stepCounter(IntegerControl value) { }

}

