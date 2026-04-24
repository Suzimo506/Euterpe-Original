namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout]
public class WMRSpatialController : XRControllerWithRumble
{
	[CompilerGenerated]
	private Vector2Control <joystick>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <joystickClicked>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private AxisControl <batteryLevel>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private AxisControl <sourceLossRisk>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private Vector3Control <pointerPosition>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private QuaternionControl <pointerRotation>k__BackingField; //Field offset: 0x1F8

	[InputControl]
	public private AxisControl batteryLevel
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
	public private Vector2Control joystick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl joystickClicked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl menu
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control pointerPosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl pointerRotation
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

	public WMRSpatialController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_batteryLevel() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	public Vector2Control get_joystick() { }

	[CompilerGenerated]
	public ButtonControl get_joystickClicked() { }

	[CompilerGenerated]
	public ButtonControl get_menu() { }

	[CompilerGenerated]
	public Vector3Control get_pointerPosition() { }

	[CompilerGenerated]
	public QuaternionControl get_pointerRotation() { }

	[CompilerGenerated]
	public Vector3Control get_sourceLossMitigationDirection() { }

	[CompilerGenerated]
	public AxisControl get_sourceLossRisk() { }

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
	private void set_batteryLevel(AxisControl value) { }

	[CompilerGenerated]
	private void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_grip(AxisControl value) { }

	[CompilerGenerated]
	private void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_joystick(Vector2Control value) { }

	[CompilerGenerated]
	private void set_joystickClicked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	private void set_pointerPosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_pointerRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_sourceLossMitigationDirection(Vector3Control value) { }

	[CompilerGenerated]
	private void set_sourceLossRisk(AxisControl value) { }

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

