namespace UnityEngine.InputSystem;

[InputControlLayout]
public class PressureSensor : Sensor
{
	[CompilerGenerated]
	private static PressureSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AxisControl <atmosphericPressure>k__BackingField; //Field offset: 0x158

	[InputControl]
	public private AxisControl atmosphericPressure
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private static PressureSensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public PressureSensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_atmosphericPressure() { }

	[CompilerGenerated]
	public static PressureSensor get_current() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private void set_atmosphericPressure(AxisControl value) { }

	[CompilerGenerated]
	private static void set_current(PressureSensor value) { }

}

