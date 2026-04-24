//Type is in global namespace

public class PnlInputPc : UISelectManage
{
	[HideInInspector]
	internal enum keyType
	{
		NormalKey = 0,
		SpecialKey = 1,
		SettingKey = 2,
		NoKey = 3,
	}

	private static PnlInputPc m_Instance; //Field offset: 0x0
	public static readonly String[] buttonProposal; //Field offset: 0x8
	public static readonly String[] revertButtonProposal; //Field offset: 0x10
	public Button switchModeL; //Field offset: 0x110
	public Button switchModeR; //Field offset: 0x118
	public Text txtButton; //Field offset: 0x120
	public Text txtScreen; //Field offset: 0x128
	private bool m_IsButton; //Field offset: 0x130
	public FancyScrollView modeFancyScrollView; //Field offset: 0x138
	public FancyScrollView buttonFancyScrollView; //Field offset: 0x140
	public FancyScrollView screenFancyScrollView; //Field offset: 0x148
	public FancyScrollView reverseFancyScrollView; //Field offset: 0x150
	public FancyScrollView vibrationFancyScrollView; //Field offset: 0x158
	public FancyScrollView keyboardFeverFancyScrollView; //Field offset: 0x160
	public FancyScrollView joystickFeverFancyScrollView; //Field offset: 0x168
	public Transform keyboardFeverTipsBtn; //Field offset: 0x170
	public Transform joystickFeverTipsBtn; //Field offset: 0x178
	public PointsBar buttonPointsBar; //Field offset: 0x180
	public PointsBar screenPointsBar; //Field offset: 0x188
	public Color highLightColor; //Field offset: 0x190
	public Color normalColor; //Field offset: 0x1A0
	public AudioClip scrollAudio; //Field offset: 0x1B0
	public float titleAnimTime; //Field offset: 0x1B8
	public Image onCustomizeBg; //Field offset: 0x1C0
	public int buttonProposalIndex; //Field offset: 0x1C8
	public int screenProposalIndex; //Field offset: 0x1CC
	private bool m_IsReverse; //Field offset: 0x1D0
	private bool m_IsVibration; //Field offset: 0x1D1
	private bool m_IsManualFever; //Field offset: 0x1D2
	private bool m_IsInitReverse; //Field offset: 0x1D3
	private bool m_IsInitVibration; //Field offset: 0x1D4
	private bool m_IsInitManualFever; //Field offset: 0x1D5
	private bool m_IsInitManualFever_Joystick; //Field offset: 0x1D6
	public GameObject[] keyboardTypeList; //Field offset: 0x1D8
	public Button btnCustom; //Field offset: 0x1E0
	public Button btnKeyboardUI; //Field offset: 0x1E8
	public Button btnHandleUI; //Field offset: 0x1F0
	public Button btnCancelCustomize; //Field offset: 0x1F8
	public InputCustomizeSelect customizeSelect; //Field offset: 0x200
	public List<GameObject> m_CustomKeyList; //Field offset: 0x208
	public Selectable feverCustomKey; //Field offset: 0x210
	public int currentSelectedCustomKeyIndex; //Field offset: 0x218
	private GameObject m_CurrentSelectedCustomKey; //Field offset: 0x220
	public Dictionary<String, Sprite> specialBtnImgDict; //Field offset: 0x228
	public string currentButtonProposal; //Field offset: 0x230
	private Dictionary<String, List`1<KeyCode>> m_SourceKey_Dict; //Field offset: 0x238
	private StandloneCtrlConfig m_Config; //Field offset: 0x240
	[HideInInspector]
	public bool customIsChanged; //Field offset: 0x248
	[HideInInspector]
	public bool allowListenKey; //Field offset: 0x249
	[HideInInspector]
	public bool shiftAndCtrlCheck; //Field offset: 0x24A
	[HideInInspector]
	public string shiftOrCtrl; //Field offset: 0x250
	private string m_ShiftOrCtrlUiName; //Field offset: 0x258
	private Dictionary<String, String> m_SimplifyKeyDict; //Field offset: 0x260
	private bool m_IsInit; //Field offset: 0x268
	public GameObject feverBase; //Field offset: 0x270
	public List<GameObject> otherDefaultFeverBtn; //Field offset: 0x278

	private static PnlInputPc() { }

	public PnlInputPc() { }

	[CompilerGenerated]
	private void <OnInit>b__60_0() { }

	[CompilerGenerated]
	private void <OnInit>b__60_1() { }

	[CompilerGenerated]
	private void <OnInit>b__60_2() { }

	[CompilerGenerated]
	private void <OnInit>b__60_3() { }

	[CompilerGenerated]
	private void <OnInit>b__60_4() { }

	[CompilerGenerated]
	private void <OnInit>b__60_5() { }

	public void ChangeCustomKeyUI(GameObject obj, string key) { }

	public void ChangeCustomKeyUI(string key) { }

	public void ChangeCutomKeyListUI() { }

	public virtual GameObject DefaultSelectObj() { }

	public GameObject GetCurrentSelectedCustomKey() { }

	private void GetSourceKeyList() { }

	public static PnlInputPc Instance() { }

	private void Loop(float time) { }

	public void OnCancelCustomize() { }

	public void OnClickBtnCustom() { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	public virtual void OnInit() { }

	private void OnJoystickFeverFsvSelect(int index) { }

	private void OnKeyboardFeverFsvSelect(int index) { }

	private void OnKeySetting(string buttonName) { }

	private void OnModeFsvSelect() { }

	private void OnModeSelectedInit(int index) { }

	private void OnReverseFsvSelect(int index) { }

	protected virtual void OnSelect(GameObject currentObj) { }

	private void OnSelectObject() { }

	private void OnVibrationFsvSelect(int index) { }

	private void PlayAudio() { }

	public void SetButtonProposal(int index) { }

	public void SetCurrentCustomKey(GameObject obj) { }

	public void SetCustomKeyList() { }

	private void SetCustomKeyNavigation() { }

	private void SetFeverTipsBtnHighlight(FancyScrollView fsv, Color color, bool enable) { }

	private void SetFeverUI(bool enable) { }

	private void SetModeTitleAnim() { }

	private void SetOtherDefaultFeverBtns(bool enable) { }

	public void SetRepeatKeyToNoUI(int repeatIndex) { }

	private void SetReverseUI() { }

	public void SetScreenProposal(int index) { }

	public virtual List<GameObject> SetSelectableObj() { }

	private void SetSelectObjHighLight(FancyScrollView fsv, bool enable) { }

	private void SetSelectObjHighLight(GameObject selectObj, bool enable) { }

	public void SetSourceRepeatList() { }

	public string SimplifyKey(string keyName) { }

}

