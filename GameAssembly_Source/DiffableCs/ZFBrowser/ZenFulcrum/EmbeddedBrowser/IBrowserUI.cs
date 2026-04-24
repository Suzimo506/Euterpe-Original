namespace ZenFulcrum.EmbeddedBrowser;

public interface IBrowserUI
{

	public BrowserCursor BrowserCursor
	{
		 get { } //Length: 0
	}

	public BrowserInputSettings InputSettings
	{
		 get { } //Length: 0
	}

	public bool KeyboardHasFocus
	{
		 get { } //Length: 0
	}

	public List<Event> KeyEvents
	{
		 get { } //Length: 0
	}

	public MouseButton MouseButtons
	{
		 get { } //Length: 0
	}

	public bool MouseHasFocus
	{
		 get { } //Length: 0
	}

	public Vector2 MousePosition
	{
		 get { } //Length: 0
	}

	public Vector2 MouseScroll
	{
		 get { } //Length: 0
	}

	public BrowserCursor get_BrowserCursor() { }

	public BrowserInputSettings get_InputSettings() { }

	public bool get_KeyboardHasFocus() { }

	public List<Event> get_KeyEvents() { }

	public MouseButton get_MouseButtons() { }

	public bool get_MouseHasFocus() { }

	public Vector2 get_MousePosition() { }

	public Vector2 get_MouseScroll() { }

	public void InputUpdate() { }

}

