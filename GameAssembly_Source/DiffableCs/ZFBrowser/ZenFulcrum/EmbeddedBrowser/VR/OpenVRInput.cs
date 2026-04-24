namespace ZenFulcrum.EmbeddedBrowser.VR;

internal class OpenVRInput : VRInput
{
	private enum InputMode
	{
		Direct = 0,
		MappedActions = 1,
	}

	private const string PointPose = "/actions/ui/in/UIPointer"; //Field offset: 0x0
	private const string LeftClickAction = "/actions/ui/in/InteractMain"; //Field offset: 0x0
	private const string MiddleClickAction = "/actions/ui/in/InteractMiddle"; //Field offset: 0x0
	private const string RightClickAction = "/actions/ui/in/InteractContext"; //Field offset: 0x0
	private const string JoystickScrollAction = "/actions/ui/in/JoystickScroll"; //Field offset: 0x0
	private const string TouchpadScrollTouch = "/actions/ui/in/TouchpadScrollTouch"; //Field offset: 0x0
	private const string TouchpadScrollPosition = "/actions/ui/in/TouchpadScrollPosition"; //Field offset: 0x0
	private InputMode mode; //Field offset: 0x10
	private VRControllerState_t direct_lastState; //Field offset: 0x18
	private ulong pointPose; //Field offset: 0x58
	private ulong leftClick; //Field offset: 0x60
	private ulong middleClick; //Field offset: 0x68
	private ulong rightClick; //Field offset: 0x70
	private ulong joystickScroll; //Field offset: 0x78
	private ulong touchPadScrollTouch; //Field offset: 0x80
	private ulong touchPadScrollPos; //Field offset: 0x88
	private ulong leftHand; //Field offset: 0x90
	private ulong rightHand; //Field offset: 0x98
	private JoyPadType jpType; //Field offset: 0xA0

	public OpenVRInput() { }

	protected void Direct_ReadState(XRNodeState node) { }

	private ulong GetActionHandle(string handleName, string name) { }

	public virtual float GetAxis(XRNodeState node, InputAxis axis) { }

	private int GetDeviceId(XRNodeState node) { }

	private bool GetDigitalInput(ulong action, XRNodeState node) { }

	public virtual JoyPadType GetJoypadTypes(XRNodeState node) { }

	public virtual string GetNodeName(XRNodeState node) { }

	public virtual Pose GetPose(XRNodeState node) { }

	private Pose GetPoseInput(ulong action, XRNodeState node) { }

	public static string GetStringProperty(uint deviceId, ETrackedDeviceProperty prop) { }

	private Vector2 GetVector2Input(ulong action, XRNodeState node) { }

}

