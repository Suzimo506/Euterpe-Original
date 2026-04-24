namespace UnityEngine.InputSystem;

[InputControlLayout]
public class LightSensor : Sensor
{
	[CompilerGenerated]
	private static LightSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AxisControl <lightLevel>k__BackingField; //Field offset: 0x158

	public private static LightSensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	[InputControl]
	public private AxisControl lightLevel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public LightSensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static LightSensor get_current() { }

	[CompilerGenerated]
	public AxisControl get_lightLevel() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(LightSensor value) { }

	[CompilerGenerated]
	private void set_lightLevel(AxisControl value) { }

}

