namespace UnityEngine.InputSystem;

[InputControlLayout]
public class MagneticFieldSensor : Sensor
{
	[CompilerGenerated]
	private static MagneticFieldSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3Control <magneticField>k__BackingField; //Field offset: 0x158

	public private static MagneticFieldSensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	[InputControl]
	public private Vector3Control magneticField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public MagneticFieldSensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static MagneticFieldSensor get_current() { }

	[CompilerGenerated]
	public Vector3Control get_magneticField() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(MagneticFieldSensor value) { }

	[CompilerGenerated]
	private void set_magneticField(Vector3Control value) { }

}

