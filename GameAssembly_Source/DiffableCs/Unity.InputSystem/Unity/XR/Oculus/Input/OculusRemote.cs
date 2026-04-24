namespace Unity.XR.Oculus.Input;

[InputControlLayout]
public class OculusRemote : InputDevice
{
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x168

	[InputControl]
	public private ButtonControl back
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
	public private Vector2Control touchpad
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public OculusRemote() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_back() { }

	[CompilerGenerated]
	public ButtonControl get_start() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	private void set_back(ButtonControl value) { }

	[CompilerGenerated]
	private void set_start(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpad(Vector2Control value) { }

}

