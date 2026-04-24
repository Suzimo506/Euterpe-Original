namespace Assets.Scripts.PeroTools.UI;

public class InputKeyBinding : MonoBehaviour, IInputKeyBinding
{
	internal enum Type
	{
		Button = 0,
		AxisPositive = 1,
		AxisNegative = 2,
	}

	private static List<InputKeyBinding> m_InputKeyBindings; //Field offset: 0x0
	private static bool s_ThisKeyInvoke; //Field offset: 0x8
	private UISelectManage m_UiManage; //Field offset: 0x18
	public Type btnType; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string buttonName; //Field offset: 0x28
	public string axisName; //Field offset: 0x30
	public float axisSpeed; //Field offset: 0x38
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public InputKeyBinding excludeButton; //Field offset: 0x40
	private ReuseScorllRect m_ReuseScorllRect; //Field offset: 0x48
	private Scrollbar m_Scrollbar; //Field offset: 0x50
	private Slider m_Slider; //Field offset: 0x58
	public bool onlyHandleController; //Field offset: 0x60
	public bool onlyKeyboard; //Field offset: 0x61
	public bool ignorePnlCheck; //Field offset: 0x62
	private bool m_IsAxisInUse; //Field offset: 0x63
	private bool m_AixsLongPress; //Field offset: 0x64
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool disableSimpleKey; //Field offset: 0x65
	public bool IsPressUpInvok; //Field offset: 0x66
	public bool IsNeedMouseUpInvokEvent; //Field offset: 0x67
	private bool m_IsPress; //Field offset: 0x68

	public override UISelectManage GetPanelOrder
	{
		 get { } //Length: 5
	}

	public override bool IsOnCurrentPanel
	{
		 get { } //Length: 39
	}

	public InputKeyBinding() { }

	private void Awake() { }

	private bool ExceptButton() { }

	public override UISelectManage get_GetPanelOrder() { }

	public override bool get_IsOnCurrentPanel() { }

	private bool IsGetExcludeButtonDown() { }

	private bool IsReuseScorllRect() { }

	private bool IsScrollBar() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void PressDown() { }

	private void PressUp() { }

	public override void SetPanelOrder(UISelectManage uiManage) { }

	private void Update() { }

}

