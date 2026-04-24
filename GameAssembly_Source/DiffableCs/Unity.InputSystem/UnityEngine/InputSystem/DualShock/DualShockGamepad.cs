namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout]
public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics
{
	[CompilerGenerated]
	private static DualShockGamepad <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ButtonControl <touchpadButton>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private ButtonControl <optionsButton>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private ButtonControl <shareButton>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private ButtonControl <L1>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private ButtonControl <R1>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private ButtonControl <L2>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private ButtonControl <R2>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private ButtonControl <L3>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private ButtonControl <R3>k__BackingField; //Field offset: 0x218

	public private static DualShockGamepad current
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		private set { } //Length: 66
	}

	[InputControl]
	public ButtonControl L1
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl L2
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl L3
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl optionsButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl R1
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl R2
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl R3
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl shareButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public ButtonControl touchpadButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public DualShockGamepad() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static DualShockGamepad get_current() { }

	[CompilerGenerated]
	public ButtonControl get_L1() { }

	[CompilerGenerated]
	public ButtonControl get_L2() { }

	[CompilerGenerated]
	public ButtonControl get_L3() { }

	[CompilerGenerated]
	public ButtonControl get_optionsButton() { }

	[CompilerGenerated]
	public ButtonControl get_R1() { }

	[CompilerGenerated]
	public ButtonControl get_R2() { }

	[CompilerGenerated]
	public ButtonControl get_R3() { }

	[CompilerGenerated]
	public ButtonControl get_shareButton() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadButton() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(DualShockGamepad value) { }

	[CompilerGenerated]
	protected void set_L1(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_L2(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_L3(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_optionsButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_R1(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_R2(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_R3(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_shareButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_touchpadButton(ButtonControl value) { }

	public override void SetLightBarColor(Color color) { }

}

