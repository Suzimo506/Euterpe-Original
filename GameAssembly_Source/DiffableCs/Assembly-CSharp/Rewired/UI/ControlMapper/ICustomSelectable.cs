namespace Rewired.UI.ControlMapper;

public interface ICustomSelectable : ICancelHandler, IEventSystemHandler
{

	public event UnityAction CancelEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool autoNavDown
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool autoNavLeft
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool autoNavRight
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool autoNavUp
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Color disabledHighlightedColor
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Sprite disabledHighlightedSprite
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string disabledHighlightedTrigger
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_CancelEvent(UnityAction value) { }

	public bool get_autoNavDown() { }

	public bool get_autoNavLeft() { }

	public bool get_autoNavRight() { }

	public bool get_autoNavUp() { }

	public Color get_disabledHighlightedColor() { }

	public Sprite get_disabledHighlightedSprite() { }

	public string get_disabledHighlightedTrigger() { }

	[CompilerGenerated]
	public void remove_CancelEvent(UnityAction value) { }

	public void set_autoNavDown(bool value) { }

	public void set_autoNavLeft(bool value) { }

	public void set_autoNavRight(bool value) { }

	public void set_autoNavUp(bool value) { }

	public void set_disabledHighlightedColor(Color value) { }

	public void set_disabledHighlightedSprite(Sprite value) { }

	public void set_disabledHighlightedTrigger(string value) { }

}

