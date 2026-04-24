namespace UnityEngine.InputSystem;

[InputControlLayout]
public class AmbientTemperatureSensor : Sensor
{
	[CompilerGenerated]
	private static AmbientTemperatureSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AxisControl <ambientTemperature>k__BackingField; //Field offset: 0x158

	[InputControl]
	public private AxisControl ambientTemperature
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private static AmbientTemperatureSensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public AmbientTemperatureSensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_ambientTemperature() { }

	[CompilerGenerated]
	public static AmbientTemperatureSensor get_current() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private void set_ambientTemperature(AxisControl value) { }

	[CompilerGenerated]
	private static void set_current(AmbientTemperatureSensor value) { }

}

