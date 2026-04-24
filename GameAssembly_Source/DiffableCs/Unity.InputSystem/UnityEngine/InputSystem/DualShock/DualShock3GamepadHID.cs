namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout]
public class DualShock3GamepadHID : DualShockGamepad
{
	[CompilerGenerated]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x230

	public private ButtonControl leftTriggerButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private ButtonControl playStationButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private ButtonControl rightTriggerButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public DualShock3GamepadHID() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_leftTriggerButton() { }

	[CompilerGenerated]
	public ButtonControl get_playStationButton() { }

	[CompilerGenerated]
	public ButtonControl get_rightTriggerButton() { }

	[CompilerGenerated]
	private void set_leftTriggerButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_playStationButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_rightTriggerButton(ButtonControl value) { }

}

