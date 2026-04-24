using System.Collections.Generic;
using Assets.Scripts.GameCore.Controller.Configs;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels.PnlInputs.PCInputModules;

[Token(Token = "0x20001CA")]
public class PnlInputKeyboard : MonoBehaviour
{
	[Token(Token = "0x2000A64")]
	public enum KeyboardInputType
	{
		[Token(Token = "0x40036E5")]
		TypeA,
		[Token(Token = "0x40036E6")]
		TypeB,
		[Token(Token = "0x40036E7")]
		TypeC,
		[Token(Token = "0x40036E8")]
		TypeD,
		[Token(Token = "0x40036E9")]
		Custom
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B44")]
	private PnlInputPc m_ParentPnl;

	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x20")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView buttonFancyScrollView;

	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x28")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView keyboardFeverFancyScrollView;

	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x30")]
	public Transform keyboardFeverTipsBtn;

	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x38")]
	public PointsBar buttonPointsBar;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B49")]
	public Button btnKeyboardUI;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B4A")]
	public Button btnCancelCustomize;

	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x50")]
	public Button btnCustom;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B4C")]
	public GameObject[] keyboardTypeList;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B4D")]
	public GameObject[] onCustomToHideObjList;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x68")]
	public InputCustomizeSelect customizeSelect;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B4F")]
	public List<PCCustomKeyCell> customKeyList;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B50")]
	public List<PCCustomKeyCell> customFeverKeyList;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B51")]
	public List<GameObject> feverBtns;

	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x88")]
	public GameObject feverBase;

	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000B53")]
	private PCCustomKeyCell m_KeyBattleAir;

	[SerializeField]
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x98")]
	private PCCustomKeyCell m_KeyBattleGround;

	[Token(Token = "0x4000B55")]
	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	private PCCustomKeyCell m_KeyBattleFever;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B56")]
	[SerializeField]
	private CustomInputScrollRect m_KeyBattleAirScroll;

	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private CustomInputScrollRect m_KeyBattleGroundScroll;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0xB8")]
	private List<Selectable> m_CustomKeySelects;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000B59")]
	private List<Selectable> m_CustomFeverSelects;

	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0xC8")]
	public int buttonProposalIndex;

	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0xD0")]
	public string currentButtonProposal;

	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0xD8")]
	public int currentSelectedCustomKeyIndex;

	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000B5D")]
	public bool allowListenKey;

	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0xDD")]
	public bool shiftAndCtrlCheck;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000B5F")]
	public string shiftOrCtrl;

	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0xE8")]
	private PCCustomKeyCell m_CurrentSelectedCustomKey;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000B61")]
	private Dictionary<string, List<KeyCode>> m_SourceKeyDict;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000B62")]
	private StandloneCtrlConfig m_Config;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000B63")]
	private string m_ShiftOrCtrlUiName;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000B64")]
	private string m_CheckShiftAndCtrlLooperUid;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000B65")]
	private bool m_IsKeySetsFirstInit;

	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x111")]
	private bool m_IsFeverSetFirstInit;

	[Address(RVA = "0x4D65D0", Offset = "0x4D4DD0", Length = "0x1FB")]
	[Token(Token = "0x6000CDA")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x4D7EC0", Offset = "0x4D66C0", Length = "0x84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x4DB440", Offset = "0x4D9C40", Length = "0x109")]
	private void Update()
	{
	}

	[Address(RVA = "0x4D6F00", Offset = "0x4D5700", Length = "0x35E")]
	[Token(Token = "0x6000CDD")]
	public void Init()
	{
	}

	[Address(RVA = "0x4D83B0", Offset = "0x4D6BB0", Length = "0x10D")]
	[Token(Token = "0x6000CDE")]
	public void Release()
	{
	}

	[Address(RVA = "0x4D7260", Offset = "0x4D5A60", Length = "0x4B1")]
	[Token(Token = "0x6000CDF")]
	private void Loop(float time)
	{
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x4D6930", Offset = "0x4D5130", Length = "0x165")]
	public void ChangeCustomKeyUI(string key)
	{
	}

	[Address(RVA = "0x4D8170", Offset = "0x4D6970", Length = "0x195")]
	[Token(Token = "0x6000CE1")]
	private void RefreshScrollValueWhenSelectKey(PCCustomKeyCell selectObj, bool isAxisDown)
	{
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x4D8050", Offset = "0x4D6850", Length = "0x113")]
	private void RefreshScollContent()
	{
	}

	[Address(RVA = "0x4D6AA0", Offset = "0x4D52A0", Length = "0x3DF")]
	[Token(Token = "0x6000CE3")]
	private void ChangeCutomKeyListUI()
	{
	}

	[Address(RVA = "0x4D67D0", Offset = "0x4D4FD0", Length = "0x159")]
	[Token(Token = "0x6000CE4")]
	private void ChangeCustomKeyUI(PCCustomKeyCell customCell, string key)
	{
	}

	[Address(RVA = "0x4D6E80", Offset = "0x4D5680", Length = "0x72")]
	[Token(Token = "0x6000CE5")]
	private void GetSourceKeyList()
	{
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x4D8D60", Offset = "0x4D7560", Length = "0x823")]
	private void SetCustomKeyList()
	{
	}

	[Address(RVA = "0x4D9630", Offset = "0x4D7E30", Length = "0x46E")]
	[Token(Token = "0x6000CE7")]
	private void SetSourceRepeatList()
	{
	}

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x4D9590", Offset = "0x4D7D90", Length = "0x97")]
	private void SetRepeatKeyToNoUI(int repeatIndex)
	{
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x4D7D80", Offset = "0x4D6580", Length = "0x133")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4DB390", Offset = "0x4D9B90", Length = "0xAC")]
	[Token(Token = "0x6000CEA")]
	private void UnRegistEvts()
	{
	}

	[Address(RVA = "0x4870D0", Offset = "0x4858D0", Length = "0x8")]
	[Token(Token = "0x6000CEB")]
	public PCCustomKeyCell GetCurrentCustomKey()
	{
		return null;
	}

	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x4D8B70", Offset = "0x4D7370", Length = "0x1E8")]
	public void SetCurrentCustomKey(PCCustomKeyCell cell)
	{
	}

	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x4D7BD0", Offset = "0x4D63D0", Length = "0x9E")]
	private void OnClickBtnCustomStart(PCCustomKeyCell obj)
	{
	}

	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x4D7AB0", Offset = "0x4D62B0", Length = "0x11F")]
	private void OnClickBtnCustomListening()
	{
	}

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x4D7880", Offset = "0x4D6080", Length = "0x226")]
	private void OnClickBtnCustomComplete(string keyName)
	{
	}

	[Address(RVA = "0x4D7720", Offset = "0x4D5F20", Length = "0x156")]
	[Token(Token = "0x6000CF0")]
	public void OnCancelCustomize()
	{
	}

	[Address(RVA = "0x4D8800", Offset = "0x4D7000", Length = "0x364")]
	[Token(Token = "0x6000CF1")]
	private void SetButtonProposal(int index)
	{
	}

	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x4D7F50", Offset = "0x4D6750", Length = "0xFB")]
	private void OnKeyboardFeverFsvSelect(int index)
	{
	}

	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x4D7C70", Offset = "0x4D6470", Length = "0x10C")]
	private void OnClickBtnCustom()
	{
	}

	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x4D8310", Offset = "0x4D6B10", Length = "0x96")]
	private void RefreshSettingUIState()
	{
	}

	[Address(RVA = "0x4D84C0", Offset = "0x4D6CC0", Length = "0x330")]
	[Token(Token = "0x6000CF5")]
	private void ResetFeverNavigation()
	{
	}

	[Address(RVA = "0x4DB550", Offset = "0x4D9D50", Length = "0x185")]
	[Token(Token = "0x6000CF6")]
	public PnlInputKeyboard()
	{
	}
}
