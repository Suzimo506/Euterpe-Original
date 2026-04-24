namespace ZenFulcrum.EmbeddedBrowser;

public class VRBrowserHand : MonoBehaviour
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public XRNode hand; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject visualization; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float scrollThreshold; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float trackpadScrollSpeed; //Field offset: 0x2C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float joystickScrollSpeed; //Field offset: 0x30
	private Vector2 lastTouchPoint; //Field offset: 0x34
	private bool touchIsScrolling; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <Tracked>k__BackingField; //Field offset: 0x3D
	[CompilerGenerated]
	private MouseButton <DepressedButtons>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Vector2 <ScrollDelta>k__BackingField; //Field offset: 0x44
	private XRNodeState nodeState; //Field offset: 0x50
	private VRInput input; //Field offset: 0xB0
	private int lastFrame; //Field offset: 0xB8
	private List<XRNodeState> states; //Field offset: 0xC0
	private bool hasTouchpad; //Field offset: 0xC8

	public private MouseButton DepressedButtons
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector2 ScrollDelta
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool Tracked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public VRBrowserHand() { }

	[CompilerGenerated]
	public MouseButton get_DepressedButtons() { }

	[CompilerGenerated]
	public Vector2 get_ScrollDelta() { }

	[CompilerGenerated]
	public bool get_Tracked() { }

	public void OnDisable() { }

	public void OnEnable() { }

	protected override void ReadInput() { }

	protected override void ReadJoystick() { }

	protected override void ReadTouchpad() { }

	[CompilerGenerated]
	private void set_DepressedButtons(MouseButton value) { }

	[CompilerGenerated]
	private void set_ScrollDelta(Vector2 value) { }

	[CompilerGenerated]
	private void set_Tracked(bool value) { }

	public override void Update() { }

	private void UpdatePreCull(Camera cam) { }

}

