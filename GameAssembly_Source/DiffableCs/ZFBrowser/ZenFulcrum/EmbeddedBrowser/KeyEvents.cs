namespace ZenFulcrum.EmbeddedBrowser;

public class KeyEvents
{
	private static readonly KeyCode[] keysToCheck; //Field offset: 0x0
	private static readonly KeyCode[] keysToIgnore; //Field offset: 0x8
	protected List<Event> keyEvents; //Field offset: 0x10
	protected List<Event> keyEventsLast; //Field offset: 0x18

	public List<Event> Events
	{
		 get { } //Length: 5
	}

	private static KeyEvents() { }

	public KeyEvents() { }

	public void Feed(Event ev) { }

	public List<Event> get_Events() { }

	public void InputUpdate() { }

	public void Press(KeyCode key) { }

	public void Release(KeyCode key) { }

	public void Type(string text) { }

}

