namespace UnityEngine.InputSystem;

[InputControlLayout]
public class HumiditySensor : Sensor
{
	[CompilerGenerated]
	private static HumiditySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AxisControl <relativeHumidity>k__BackingField; //Field offset: 0x158

	public private static HumiditySensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	[InputControl]
	public private AxisControl relativeHumidity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public HumiditySensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static HumiditySensor get_current() { }

	[CompilerGenerated]
	public AxisControl get_relativeHumidity() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(HumiditySensor value) { }

	[CompilerGenerated]
	private void set_relativeHumidity(AxisControl value) { }

}

