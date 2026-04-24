namespace UnityEngine.InputSystem;

[InputControlLayout]
public class AttitudeSensor : Sensor
{
	[CompilerGenerated]
	private static AttitudeSensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private QuaternionControl <attitude>k__BackingField; //Field offset: 0x158

	public private QuaternionControl attitude
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private static AttitudeSensor current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	public AttitudeSensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public QuaternionControl get_attitude() { }

	[CompilerGenerated]
	public static AttitudeSensor get_current() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private void set_attitude(QuaternionControl value) { }

	[CompilerGenerated]
	private static void set_current(AttitudeSensor value) { }

}

