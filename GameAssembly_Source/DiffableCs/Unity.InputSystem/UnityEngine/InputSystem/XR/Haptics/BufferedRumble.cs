namespace UnityEngine.InputSystem.XR.Haptics;

public struct BufferedRumble
{
	[CompilerGenerated]
	private HapticCapabilities <capabilities>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; //Field offset: 0x10

	public private HapticCapabilities capabilities
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		private set { } //Length: 15
	}

	private InputDevice device
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public BufferedRumble(InputDevice device) { }

	public void EnqueueRumble(Byte[] samples) { }

	[CompilerGenerated]
	public HapticCapabilities get_capabilities() { }

	[CompilerGenerated]
	private InputDevice get_device() { }

	[CompilerGenerated]
	private void set_capabilities(HapticCapabilities value) { }

	[CompilerGenerated]
	private void set_device(InputDevice value) { }

}

