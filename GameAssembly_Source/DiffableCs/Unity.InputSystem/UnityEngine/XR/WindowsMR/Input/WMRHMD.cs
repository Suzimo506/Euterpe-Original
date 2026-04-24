namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout]
public class WMRHMD : XRHMD
{
	[CompilerGenerated]
	private ButtonControl <userPresence>k__BackingField; //Field offset: 0x1A8

	[InputControl]
	[InputControl]
	[InputControl]
	public private ButtonControl userPresence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public WMRHMD() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_userPresence() { }

	[CompilerGenerated]
	private void set_userPresence(ButtonControl value) { }

}

