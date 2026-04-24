namespace Assets.Scripts.GameCore.Controller;

public class StandloneController : Controller<StandloneCtrlConfig>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__36_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ChangeButton>b__36_0() { }

	}

	public static Dictionary<String, Single> values; //Field offset: 0x0
	private Dictionary<String, List`1<KeyCode>> m_Dict; //Field offset: 0x18
	private List<KeyCode> m_List; //Field offset: 0x20
	private List<String> proposalList; //Field offset: 0x28
	private List<Int32> m_DownList; //Field offset: 0x30
	private List<Int32> m_MoveList; //Field offset: 0x38
	private List<Int32> m_UpList; //Field offset: 0x40
	private string m_CurrentClickKeyButtonName; //Field offset: 0x48
	private InputMapper m_ListenCurKey; //Field offset: 0x50
	private InputMapper m_ListenCurMouse; //Field offset: 0x58
	private List<String> m_CheckRepeatKeyList; //Field offset: 0x60
	private bool m_IsKey; //Field offset: 0x68
	private int m_RepeatIndex; //Field offset: 0x6C
	private JObject m_KeyList_JObj; //Field offset: 0x70
	private List<Int32> m_HandleGroundActionNameList; //Field offset: 0x78
	private List<Int32> m_HandleAirActionNameList; //Field offset: 0x80
	private List<Int32> m_HandleFeverActionNameList; //Field offset: 0x88

	private Player m_Player
	{
		private get { } //Length: 95
	}

	private static Player PLAYER
	{
		private get { } //Length: 95
	}

	private static StandloneController() { }

	public StandloneController() { }

	public virtual void ChangeButton(string buttonName, string newKey, string uiName) { }

	private void ChangeJsonFever(string key) { }

	private void ChangeJsonKeyList(int index, string newKey) { }

	private void ChangeJsonKeyList(string newKey) { }

	private void ChangeJsonOther(string key, string value) { }

	private bool CheckDisableKey(string key) { }

	private bool CheckInputKeyRepeat(string key) { }

	public virtual void CustomButton(string buttonName, string key) { }

	private Player get_m_Player() { }

	private static Player get_PLAYER() { }

	public virtual float GetAxisFromUI(string axisName) { }

	public virtual List<Int32> GetButton(MDButtonType buttonName) { }

	public virtual List<Int32> GetButtonDown(MDButtonType buttonName) { }

	public virtual bool GetButtonDownFromUI(string keyName) { }

	public virtual bool GetButtonFromUI(string keyName) { }

	private List<Int32> GetButtonList(BUTTON_STATE buttonState) { }

	protected virtual bool GetButtonProposal(MDButtonType buttonName) { }

	public virtual List<Int32> GetButtonUp(MDButtonType buttonName) { }

	public virtual bool GetButtonUpFromUI(string keyName) { }

	public void GetDefaultKeyList() { }

	public virtual void OnClickChangeButton(string buttonName, string keyName) { }

	public virtual void OnClickNoKeyToChange(string buttonName) { }

	public virtual void OnDisableController() { }

	public virtual void OnInit() { }

	private void OnInputMapper(InputMappedEventData data) { }

	public virtual void SaveJsonProposal(string keyboardProposal, string handleProposal, bool isVibration) { }

	public virtual void SetVibration(VibrationVaule vaule, DeviceHandles handles, float duration) { }

	public virtual void SwitchProposal(string proposalName) { }

	public virtual void UpdateRepeatList(List<String> list) { }

}

