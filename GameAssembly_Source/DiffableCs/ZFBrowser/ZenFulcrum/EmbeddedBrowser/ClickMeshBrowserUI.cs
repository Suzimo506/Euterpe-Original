namespace ZenFulcrum.EmbeddedBrowser;

[Obsolete]
public class ClickMeshBrowserUI : MonoBehaviour, IBrowserUI
{
	private static readonly KeyCode[] keysToCheck; //Field offset: 0x0
	protected MeshCollider meshCollider; //Field offset: 0x18
	[HideInInspector]
	public float maxDistance; //Field offset: 0x20
	protected List<Event> keyEvents; //Field offset: 0x28
	protected List<Event> keyEventsLast; //Field offset: 0x30
	protected bool mouseWasOver; //Field offset: 0x38
	[CompilerGenerated]
	private bool <MouseHasFocus>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private Vector2 <MousePosition>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private MouseButton <MouseButtons>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private Vector2 <MouseScroll>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <KeyboardHasFocus>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private BrowserCursor <BrowserCursor>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private BrowserInputSettings <InputSettings>k__BackingField; //Field offset: 0x60

	public override BrowserCursor BrowserCursor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override BrowserInputSettings InputSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override bool KeyboardHasFocus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override List<Event> KeyEvents
	{
		 get { } //Length: 5
	}

	protected override Ray LookRay
	{
		 get { } //Length: 113
	}

	public override MouseButton MouseButtons
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool MouseHasFocus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override Vector2 MousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override Vector2 MouseScroll
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private static ClickMeshBrowserUI() { }

	public ClickMeshBrowserUI() { }

	public void Awake() { }

	public static ClickMeshBrowserUI Create(MeshCollider meshCollider) { }

	protected void CursorUpdated() { }

	[CompilerGenerated]
	public override BrowserCursor get_BrowserCursor() { }

	[CompilerGenerated]
	public override BrowserInputSettings get_InputSettings() { }

	[CompilerGenerated]
	public override bool get_KeyboardHasFocus() { }

	public override List<Event> get_KeyEvents() { }

	protected override Ray get_LookRay() { }

	[CompilerGenerated]
	public override MouseButton get_MouseButtons() { }

	[CompilerGenerated]
	public override bool get_MouseHasFocus() { }

	[CompilerGenerated]
	public override Vector2 get_MousePosition() { }

	[CompilerGenerated]
	public override Vector2 get_MouseScroll() { }

	public override void InputUpdate() { }

	protected void LookOff() { }

	protected void LookOn() { }

	public void OnGUI() { }

	[CompilerGenerated]
	protected void set_BrowserCursor(BrowserCursor value) { }

	[CompilerGenerated]
	protected void set_InputSettings(BrowserInputSettings value) { }

	[CompilerGenerated]
	protected void set_KeyboardHasFocus(bool value) { }

	[CompilerGenerated]
	protected void set_MouseButtons(MouseButton value) { }

	[CompilerGenerated]
	protected void set_MouseHasFocus(bool value) { }

	[CompilerGenerated]
	protected void set_MousePosition(Vector2 value) { }

	[CompilerGenerated]
	protected void set_MouseScroll(Vector2 value) { }

	protected override void SetCursor(BrowserCursor newCursor) { }

}

