namespace UnityEngine.InputSystem;

[InputControlLayout]
public class ProximitySensor : Sensor
{
	[CompilerGenerated]
	private static ProximitySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AxisControl <distance>k__BackingField; //Field offset: 0x158

	public private static ProximitySensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	[InputControl]
	public private AxisControl distance
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public ProximitySensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static ProximitySensor get_current() { }

	[CompilerGenerated]
	public AxisControl get_distance() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(ProximitySensor value) { }

	[CompilerGenerated]
	private void set_distance(AxisControl value) { }

}

