namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout]
public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor
{
	public struct DualSenseHIDBluetoothInputReport
	{
		public const int ExpectedReportId = 49; //Field offset: 0x0
		public byte reportId; //Field offset: 0x0
		public byte leftStickX; //Field offset: 0x2
		public byte leftStickY; //Field offset: 0x3
		public byte rightStickX; //Field offset: 0x4
		public byte rightStickY; //Field offset: 0x5
		public byte leftTrigger; //Field offset: 0x6
		public byte rightTrigger; //Field offset: 0x7
		public byte buttons0; //Field offset: 0x9
		public byte buttons1; //Field offset: 0xA
		public byte buttons2; //Field offset: 0xB

		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	public struct DualSenseHIDGenericInputReport
	{
		public byte reportId; //Field offset: 0x0

		public static FourCC Format
		{
			 get { } //Length: 53
		}

		public static FourCC get_Format() { }

	}

	public struct DualSenseHIDMinimalInputReport
	{
		public static int ExpectedSize1; //Field offset: 0x0
		public static int ExpectedSize2; //Field offset: 0x4
		public byte reportId; //Field offset: 0x0
		public byte leftStickX; //Field offset: 0x1
		public byte leftStickY; //Field offset: 0x2
		public byte rightStickX; //Field offset: 0x3
		public byte rightStickY; //Field offset: 0x4
		public byte buttons0; //Field offset: 0x5
		public byte buttons1; //Field offset: 0x6
		public byte buttons2; //Field offset: 0x7
		public byte leftTrigger; //Field offset: 0x8
		public byte rightTrigger; //Field offset: 0x9

		private static DualSenseHIDMinimalInputReport() { }

		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	public struct DualSenseHIDUSBInputReport
	{
		public const int ExpectedReportId = 1; //Field offset: 0x0
		public byte reportId; //Field offset: 0x0
		public byte leftStickX; //Field offset: 0x1
		public byte leftStickY; //Field offset: 0x2
		public byte rightStickX; //Field offset: 0x3
		public byte rightStickY; //Field offset: 0x4
		public byte leftTrigger; //Field offset: 0x5
		public byte rightTrigger; //Field offset: 0x6
		public byte buttons0; //Field offset: 0x8
		public byte buttons1; //Field offset: 0x9
		public byte buttons2; //Field offset: 0xA

		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	[CompilerGenerated]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x230
	private Nullable<Single> m_LowFrequencyMotorSpeed; //Field offset: 0x238
	private Nullable<Single> m_HighFrequenceyMotorSpeed; //Field offset: 0x240
	private Nullable<Color> m_LightBarColor; //Field offset: 0x248
	private byte outputSequenceId; //Field offset: 0x25C

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

	public DualSenseGamepadHID() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_leftTriggerButton() { }

	[CompilerGenerated]
	public ButtonControl get_playStationButton() { }

	[CompilerGenerated]
	public ButtonControl get_rightTriggerButton() { }

	private static bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState) { }

	private static bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState) { }

	private static bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState) { }

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

	public bool SetMotorSpeedsAndLightBarColor(Nullable<Single> lowFrequency, Nullable<Single> highFrequency, Nullable<Color> color) { }

	private override bool UnityEngine.InputSystem.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	private override bool UnityEngine.InputSystem.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

}

