namespace Unity.XR.Oculus.Input;

[InputControlLayout]
public class GearVRTrackedController : XRController
{
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x1B8

	[InputControl]
	public private ButtonControl back
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control deviceAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control deviceAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector2Control touchpad
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl touchpadClicked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl touchpadTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl trigger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl triggerPressed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public GearVRTrackedController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_back() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadClicked() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadTouched() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	private void set_back(ButtonControl value) { }

	[CompilerGenerated]
	private void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	private void set_touchpadClicked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

}

