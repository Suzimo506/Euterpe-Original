namespace ZenFulcrum.EmbeddedBrowser;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class PointerUIBase : MonoBehaviour, IBrowserUI
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__77_0; //Field offset: 0x8
		public static Action <>9__77_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__77_0() { }

		internal void <.ctor>b__77_1() { }

	}

	internal struct PointerState
	{
		public int id; //Field offset: 0x0
		public bool is2D; //Field offset: 0x4
		public Vector2 position2D; //Field offset: 0x8
		public Ray position3D; //Field offset: 0x10
		public MouseButton activeButtons; //Field offset: 0x28
		public Vector2 scrollDelta; //Field offset: 0x2C

	}

	public readonly KeyEvents keyEvents; //Field offset: 0x18
	protected Browser browser; //Field offset: 0x20
	protected bool appFocused; //Field offset: 0x28
	[CompilerGenerated]
	private Action onHandlePointers; //Field offset: 0x30
	protected int currentPointerId; //Field offset: 0x38
	protected readonly List<PointerState> currentPointers; //Field offset: 0x40
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float dragMovementThreshold; //Field offset: 0x48
	protected Vector2 mouseDownPosition; //Field offset: 0x4C
	protected bool dragging; //Field offset: 0x54
	[CompilerGenerated]
	private Action onClick; //Field offset: 0x58
	protected int p_currentDown; //Field offset: 0x60
	protected int p_anyDown; //Field offset: 0x64
	protected int p_currentOver; //Field offset: 0x68
	protected int p_anyOver; //Field offset: 0x6C
	protected bool mouseWasOver; //Field offset: 0x70
	protected int focusForceCount; //Field offset: 0x74
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Camera viewCamera; //Field offset: 0x78
	public bool enableMouseInput; //Field offset: 0x80
	public bool enableTouchInput; //Field offset: 0x81
	public bool enableFPSInput; //Field offset: 0x82
	public bool enableVRInput; //Field offset: 0x83
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float maxDistance; //Field offset: 0x84
	[Space]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool disableMouseEmulation; //Field offset: 0x88
	protected VRBrowserHand[] vrHands; //Field offset: 0x90
	[CompilerGenerated]
	private bool <MouseHasFocus>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Vector2 <MousePosition>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private MouseButton <MouseButtons>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private Vector2 <MouseScroll>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <KeyboardHasFocus>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private BrowserCursor <BrowserCursor>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private BrowserInputSettings <InputSettings>k__BackingField; //Field offset: 0xC0

	public event Action onClick
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onHandlePointers
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override BrowserCursor BrowserCursor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public override BrowserInputSettings InputSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public override bool KeyboardHasFocus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override List<Event> KeyEvents
	{
		 get { } //Length: 27
	}

	public override MouseButton MouseButtons
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool MouseHasFocus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector2 MousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override Vector2 MouseScroll
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected PointerUIBase() { }

	[CompilerGenerated]
	public void add_onClick(Action value) { }

	[CompilerGenerated]
	public void add_onHandlePointers(Action value) { }

	public override void Awake() { }

	protected override void CalculatePointer() { }

	protected void CursorUpdated() { }

	protected override void FeedFPS() { }

	protected override void FeedMousePointer() { }

	public override void FeedPointerState(PointerState state) { }

	protected override void FeedTouchPointers() { }

	protected override void FeedVRPointers() { }

	public void ForceKeyboardHasFocus(bool force) { }

	[CompilerGenerated]
	public override BrowserCursor get_BrowserCursor() { }

	[CompilerGenerated]
	public override BrowserInputSettings get_InputSettings() { }

	[CompilerGenerated]
	public override bool get_KeyboardHasFocus() { }

	public override List<Event> get_KeyEvents() { }

	[CompilerGenerated]
	public override MouseButton get_MouseButtons() { }

	[CompilerGenerated]
	public override bool get_MouseHasFocus() { }

	[CompilerGenerated]
	public override Vector2 get_MousePosition() { }

	[CompilerGenerated]
	public override Vector2 get_MouseScroll() { }

	public abstract void GetCurrentHitLocation(out Vector3 pos, out Quaternion rot) { }

	public override void InputUpdate() { }

	protected abstract Vector2 MapPointerToBrowser(Vector2 screenPosition, int pointerId) { }

	protected abstract Vector2 MapRayToBrowser(Ray worldRay, int pointerId) { }

	protected void MouseIsOff() { }

	protected void MouseIsOver() { }

	public void OnApplicationFocus(bool focused) { }

	public void OnGUI() { }

	protected override void OnHandlePointers() { }

	[CompilerGenerated]
	public void remove_onClick(Action value) { }

	[CompilerGenerated]
	public void remove_onHandlePointers(Action value) { }

	[CompilerGenerated]
	protected override void set_BrowserCursor(BrowserCursor value) { }

	[CompilerGenerated]
	protected override void set_InputSettings(BrowserInputSettings value) { }

	[CompilerGenerated]
	protected override void set_KeyboardHasFocus(bool value) { }

	[CompilerGenerated]
	protected override void set_MouseButtons(MouseButton value) { }

	[CompilerGenerated]
	protected override void set_MouseHasFocus(bool value) { }

	[CompilerGenerated]
	protected override void set_MousePosition(Vector2 value) { }

	[CompilerGenerated]
	protected override void set_MouseScroll(Vector2 value) { }

}

