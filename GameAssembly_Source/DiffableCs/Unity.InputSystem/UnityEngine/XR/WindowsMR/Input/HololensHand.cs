namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout]
public class HololensHand : XRController
{
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private ButtonControl <airTap>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private AxisControl <sourceLossRisk>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; //Field offset: 0x190

	[InputControl]
	public private ButtonControl airTap
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control deviceVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control sourceLossMitigationDirection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl sourceLossRisk
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public HololensHand() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_airTap() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_sourceLossMitigationDirection() { }

	[CompilerGenerated]
	public AxisControl get_sourceLossRisk() { }

	[CompilerGenerated]
	private void set_airTap(ButtonControl value) { }

	[CompilerGenerated]
	private void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_sourceLossMitigationDirection(Vector3Control value) { }

	[CompilerGenerated]
	private void set_sourceLossRisk(AxisControl value) { }

}

