namespace ZenFulcrum.EmbeddedBrowser;

internal class BrowserInput
{
	private class ButtonHistory
	{
		public float lastPressTime; //Field offset: 0x10
		public int repeatCount; //Field offset: 0x14
		public Vector3 lastPosition; //Field offset: 0x18

		public ButtonHistory() { }

		public void ButtonPress(Vector3 mousePos, IBrowserUI uiHandler, Vector2 browserSize) { }

	}

	private static HashSet<KeyCode> keysToReleaseOnFocusLoss; //Field offset: 0x0
	private const float maxScrollEventRate = 0.06666667; //Field offset: 0x0
	private readonly Browser browser; //Field offset: 0x10
	private bool kbWasFocused; //Field offset: 0x18
	private bool mouseWasFocused; //Field offset: 0x19
	public List<Event> extraEventsToInject; //Field offset: 0x20
	private MouseButton prevButtons; //Field offset: 0x28
	private Vector2 prevPos; //Field offset: 0x2C
	private readonly ButtonHistory leftClickHistory; //Field offset: 0x38
	private Vector2 accumulatedScroll; //Field offset: 0x40
	private float lastScrollEvent; //Field offset: 0x48

	private static BrowserInput() { }

	public BrowserInput(Browser browser) { }

	private void FeedScrolling(Vector2 mouseScroll, float scrollSpeed) { }

	protected void FireCommands(Event ev) { }

	public void HandleFocusLoss() { }

	public void HandleInput() { }

	private void HandleKeyInput() { }

	private void HandleKeyInput(List<Event> keyEvents) { }

	private void HandleMouseInput() { }

}

