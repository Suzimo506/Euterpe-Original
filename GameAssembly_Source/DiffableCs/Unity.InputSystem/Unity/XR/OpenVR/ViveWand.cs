namespace Unity.XR.OpenVR;

[InputControlLayout]
public class ViveWand : XRControllerWithRumble
{
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private ButtonControl <primary>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ButtonControl <trackpadPressed>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <trackpadTouched>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private Vector2Control <trackpad>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1C0

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
	public private ButtonControl primary
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector2Control trackpad
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl trackpadPressed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl trackpadTouched
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

	public ViveWand() { }

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
	public ButtonControl get_primary() { }

	[CompilerGenerated]
	public Vector2Control get_trackpad() { }

	[CompilerGenerated]
	public ButtonControl get_trackpadPressed() { }

	[CompilerGenerated]
	public ButtonControl get_trackpadTouched() { }

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
	private void set_primary(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackpad(Vector2Control value) { }

	[CompilerGenerated]
	private void set_trackpadPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

}

