namespace Unity.XR.OpenVR;

[InputControlLayout]
public class HandedViveTracker : ViveTracker
{
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <primary>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <trackpadPressed>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1A8

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
	public private ButtonControl trackpadPressed
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

	public HandedViveTracker() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	public ButtonControl get_primary() { }

	[CompilerGenerated]
	public ButtonControl get_trackpadPressed() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	private void set_grip(AxisControl value) { }

	[CompilerGenerated]
	private void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primary(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackpadPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

}

