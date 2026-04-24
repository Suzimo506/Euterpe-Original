namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout]
public class DualShock4GamepadHID : DualShockGamepad
{
	[CompilerGenerated]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x230
	private Nullable<Single> m_LowFrequencyMotorSpeed; //Field offset: 0x238
	private Nullable<Single> m_HighFrequenceyMotorSpeed; //Field offset: 0x240
	private Nullable<Color> m_LightBarColor; //Field offset: 0x248

	public ButtonControl leftTriggerButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public ButtonControl playStationButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public ButtonControl rightTriggerButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public DualShock4GamepadHID() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_leftTriggerButton() { }

	[CompilerGenerated]
	public ButtonControl get_playStationButton() { }

	[CompilerGenerated]
	public ButtonControl get_rightTriggerButton() { }

	public virtual void PauseHaptics() { }

	public virtual void ResetHaptics() { }

	public virtual void ResumeHaptics() { }

	[CompilerGenerated]
	protected void set_leftTriggerButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_playStationButton(ButtonControl value) { }

	[CompilerGenerated]
	protected void set_rightTriggerButton(ButtonControl value) { }

	public virtual void SetLightBarColor(Color color) { }

	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color) { }

}

