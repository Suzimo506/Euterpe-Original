namespace UnityEngine.InputSystem;

[InputControlLayout]
public class GravitySensor : Sensor
{
	[CompilerGenerated]
	private static GravitySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3Control <gravity>k__BackingField; //Field offset: 0x158

	public private static GravitySensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public private Vector3Control gravity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public GravitySensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static GravitySensor get_current() { }

	[CompilerGenerated]
	public Vector3Control get_gravity() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(GravitySensor value) { }

	[CompilerGenerated]
	private void set_gravity(Vector3Control value) { }

}

