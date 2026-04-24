namespace Unity.XR.Oculus.Input;

[InputControlLayout]
public class OculusTouchController : XRControllerWithRumble
{
	[CompilerGenerated]
	private Vector2Control <thumbstick>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ButtonControl <primaryButton>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <secondaryButton>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <thumbstickClicked>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <primaryTouched>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private ButtonControl <secondaryTouched>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private AxisControl <triggerTouched>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private ButtonControl <thumbstickTouched>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x1F8

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
	public private Vector3Control deviceVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl grip
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl gripPressed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl primaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl primaryTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl secondaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl secondaryTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl start
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector2Control thumbstick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl thumbstickClicked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public private ButtonControl thumbstickTouched
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

	[InputControl]
	public private AxisControl triggerTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public OculusTouchController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	public ButtonControl get_primaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_primaryTouched() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryTouched() { }

	[CompilerGenerated]
	public ButtonControl get_start() { }

	[CompilerGenerated]
	public Vector2Control get_thumbstick() { }

	[CompilerGenerated]
	public ButtonControl get_thumbstickClicked() { }

	[CompilerGenerated]
	public ButtonControl get_thumbstickTouched() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	public AxisControl get_triggerTouched() { }

	[CompilerGenerated]
	private void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_grip(AxisControl value) { }

	[CompilerGenerated]
	private void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primaryButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondaryButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_start(ButtonControl value) { }

	[CompilerGenerated]
	private void set_thumbstick(Vector2Control value) { }

	[CompilerGenerated]
	private void set_thumbstickClicked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_thumbstickTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_triggerTouched(AxisControl value) { }

}

