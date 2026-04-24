namespace Unity.XR.Oculus.Input;

public class OculusTrackingReference : TrackedDevice
{
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x180

	[InputControl]
	public private ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public OculusTrackingReference() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	private void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

}

