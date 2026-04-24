namespace UnityEngine.InputSystem.Controls;

public class StickControl : Vector2Control
{
	[CompilerGenerated]
	private ButtonControl <up>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private ButtonControl <down>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private ButtonControl <left>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private ButtonControl <right>k__BackingField; //Field offset: 0x118

	[InputControl]
	public ButtonControl down
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl left
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public ButtonControl right
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	[InputControl]
	[InputControl]
	public ButtonControl up
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public StickControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_down() { }

	[CompilerGenerated]
	public ButtonControl get_left() { }

	[CompilerGenerated]
	public ButtonControl get_right() { }

	[CompilerGenerated]
	public ButtonControl get_up() { }

	[CompilerGenerated]
	public void set_down(ButtonControl value) { }

	[CompilerGenerated]
	public void set_left(ButtonControl value) { }

	[CompilerGenerated]
	public void set_right(ButtonControl value) { }

	[CompilerGenerated]
	public void set_up(ButtonControl value) { }

}

