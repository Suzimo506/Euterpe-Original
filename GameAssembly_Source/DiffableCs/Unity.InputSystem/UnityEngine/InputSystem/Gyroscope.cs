namespace UnityEngine.InputSystem;

[InputControlLayout]
public class Gyroscope : Sensor
{
	[CompilerGenerated]
	private static Gyroscope <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3Control <angularVelocity>k__BackingField; //Field offset: 0x158

	public private Vector3Control angularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private static Gyroscope current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public Gyroscope() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_angularVelocity() { }

	[CompilerGenerated]
	public static Gyroscope get_current() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private void set_angularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private static void set_current(Gyroscope value) { }

}

