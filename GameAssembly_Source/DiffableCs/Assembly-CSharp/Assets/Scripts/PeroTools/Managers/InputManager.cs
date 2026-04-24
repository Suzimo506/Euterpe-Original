namespace Assets.Scripts.PeroTools.Managers;

public class InputManager : Singleton<InputManager>, IPause
{
	private IControlable m_Controller; //Field offset: 0x10
	public bool customIsChanged; //Field offset: 0x18
	public string keyBoardProposal; //Field offset: 0x20
	public string handleProposal; //Field offset: 0x28
	private string m_CurrentControllerName; //Field offset: 0x30
	public bool isPauseMap; //Field offset: 0x38
	public bool isVibration; //Field offset: 0x39
	[CompilerGenerated]
	private bool <sendUiEvent>k__BackingField; //Field offset: 0x3A
	public bool isCustomMouse; //Field offset: 0x3B
	private string m_CurrentLastActiveController; //Field offset: 0x40
	private InputController m_ControllerType; //Field offset: 0x48
	private Dictionary<String, Boolean> m_MapEnables; //Field offset: 0x50

	public InputController controllerType
	{
		 get { } //Length: 4
	}

	public string currentControllerName
	{
		 get { } //Length: 5
	}

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public bool sendUiEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public InputManager() { }

	public bool CheckMouseClickUI() { }

	public void CustomButton(string buttonName, string key) { }

	public void Disable() { }

	public InputController get_controllerType() { }

	public string get_currentControllerName() { }

	public override bool get_IsGlobal() { }

	[CompilerGenerated]
	public bool get_sendUiEvent() { }

	public float GetAxisFromUI(string key) { }

	public List<Int32> GetButton(MDButtonType buttonName) { }

	public List<Int32> GetButtonDown(MDButtonType buttonName) { }

	public bool GetButtonDownFromUI(string key) { }

	public bool GetButtonFromUI(string key) { }

	public List<Int32> GetButtonUp(MDButtonType buttonName) { }

	public bool GetButtonUpFromUI(string key) { }

	public bool GetControllerMapEnable(string categoryName) { }

	public bool GetTouchs(List<TouchControl> buffer) { }

	private void Init() { }

	public bool IsConnetShouTai(out Controller shouTaiController) { }

	public bool IsConnetShouTai() { }

	private void Loop(float time) { }

	public void OnChangeSpecialButton(string buttonName, string newKey, string uiName) { }

	public void OnClickChangeButton(string buttonName, string keyName) { }

	public void OnClickNoKeyChangeButton(string buttonName) { }

	public void OnHandleConnet(string battleSceneName, bool isSucceed, bool isDead, bool isPause, bool isTutorial) { }

	public void OnSaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration) { }

	public void OnSetCustomRepeatList(List<String> list) { }

	public override void Pause(bool pauseCorountine) { }

	private void Private_SetControllerMapEnable(string categoryName, bool enable) { }

	private void Private_SetJoystickMapEnable(bool enable, MapHelper maps) { }

	private void Private_SetUIMapEnable(bool enable, MapHelper maps) { }

	public void RefreshControllerEnable() { }

	public override void Resume() { }

	public bool RewiredGetAnyButton() { }

	public float RewiredGetAxisRaw(string actionName) { }

	public bool RewiredGetButton(string actionName) { }

	public bool RewiredGetButtonDown(string actionName) { }

	public bool RewiredGetButtonUp(string actionName) { }

	private void SendSubmit() { }

	[CompilerGenerated]
	public void set_sendUiEvent(bool value) { }

	public void SetController(InputController controller) { }

	public void SetControllerHandler(IControlable controller, string inputCtrlConfigName, bool updateControl = true) { }

	public void SetControllerMapEnable(string categoryName, bool enable) { }

	public void SetNsVibration(VibrationVaule vaule, DeviceHandles handles = 3, float time = 0.05) { }

	public void SwitchButtonProposal(string name) { }

	public void UpdateLastActiveInputController() { }

}

