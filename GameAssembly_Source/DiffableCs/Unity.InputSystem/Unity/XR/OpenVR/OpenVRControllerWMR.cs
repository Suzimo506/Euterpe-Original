namespace Unity.XR.OpenVR;

[InputControlLayout]
public class OpenVRControllerWMR : XRController
{
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private ButtonControl <touchpadClick>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ButtonControl <touchpadTouch>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private Vector2Control <joystick>k__BackingField; //Field offset: 0x1C8

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
	public private ButtonControl menu
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
	public private ButtonControl touchpadClick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl touchpadTouch
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

	public OpenVRControllerWMR() { }

	protected virtual void FinishSetup() { }

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
	public ButtonControl get_menu() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadClick() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadTouch() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

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
	private void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	private void set_touchpadClick(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpadTouch(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

}

