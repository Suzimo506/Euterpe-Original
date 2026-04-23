using System.Collections.Generic;
using Assets.Scripts.GameCore.Controller.Configs;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UI.Panels.PnlInputs.PCInputModules;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000126")]
public class PnlInputPc : UISelectManage
{
	[HideInInspector]
	[Token(Token = "0x2000A1B")]
	public enum KeyType
	{
		[Token(Token = "0x4003609")]
		NormalKey,
		[Token(Token = "0x400360A")]
		SpecialKey,
		[Token(Token = "0x400360B")]
		SettingKey,
		[Token(Token = "0x400360C")]
		NoKey
	}

	[Token(Token = "0x4000710")]
	public static readonly string[] buttonProposal;

	[Token(Token = "0x4000711")]
	public static readonly string[] revertButtonProposal;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000712")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView buttonFancyScrollView;

	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x120")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView screenFancyScrollView;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000714")]
	public Button switchModeL;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000715")]
	public Button switchModeR;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000716")]
	public Text txtButton;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000717")]
	public Text txtScreen;

	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x148")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView modeFancyScrollView;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000719")]
	public float titleAnimTime;

	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x158")]
	public Image onCustomizeBg;

	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x160")]
	public int buttonProposalIndex;

	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x400071C")]
	public int screenProposalIndex;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400071D")]
	public Color highLightColor;

	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x178")]
	public Color normalColor;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x188")]
	public AudioClip scrollAudio;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000720")]
	public bool isManualFever;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x194")]
	public int currentSelectedCustomKeyIndex;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x198")]
	public Dictionary<string, Sprite> specialBtnImgDict;

	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x1A0")]
	public string currentButtonProposal;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000724")]
	private bool m_IsButton;

	[Token(Token = "0x4000725")]
	private static PnlInputPc s_Instance;

	[FieldOffset(Offset = "0x1A9")]
	[Token(Token = "0x4000726")]
	public bool isReverse;

	[FieldOffset(Offset = "0x1AA")]
	[Token(Token = "0x4000727")]
	public bool isVibration;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000728")]
	private GameObject m_CurrentSelectedCustomKey;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x1B8")]
	private Dictionary<string, List<KeyCode>> m_SourceKeyDict;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400072A")]
	private StandloneCtrlConfig m_Config;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x1C8")]
	private bool m_IsInit;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x1D0")]
	public PnlInputKeyboard pnlInputKeyboard;

	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x1D8")]
	public PnlInputJoystick pnlInputJoystick;

	[Address(RVA = "0x7A1C40", Offset = "0x7A0440", Length = "0x57")]
	[Token(Token = "0x6000849")]
	public static PnlInputPc Instance()
	{
		return null;
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0x7A1CA0", Offset = "0x7A04A0", Length = "0x116")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x7A2130", Offset = "0x7A0930", Length = "0x10A")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x7A2240", Offset = "0x7A0A40", Length = "0x30C")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x7A2550", Offset = "0x7A0D50", Length = "0x1E4")]
	private void OnModeFsvSelect()
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x7A2740", Offset = "0x7A0F40", Length = "0x47")]
	private void OnModeSelectedInit(int index)
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x7A3F90", Offset = "0x7A2790", Length = "0x294")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x7A2790", Offset = "0x7A0F90", Length = "0x6EE")]
	[Token(Token = "0x6000850")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x7A1C00", Offset = "0x7A0400", Length = "0x3E")]
	[Token(Token = "0x6000851")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x7A1DC0", Offset = "0x7A05C0", Length = "0x360")]
	[Token(Token = "0x6000852")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x7A3750", Offset = "0x7A1F50", Length = "0x837")]
	[Token(Token = "0x6000853")]
	public void SetSelectObjHighLight(Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv, bool enable)
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x7A2F70", Offset = "0x7A1770", Length = "0x1BC")]
	private void SetFeverTipsBtnHighlight(Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv, Color color, bool enable)
	{
	}

	[Address(RVA = "0x7A36A0", Offset = "0x7A1EA0", Length = "0xA1")]
	[Token(Token = "0x6000855")]
	private void SetSelectObjHighLight(GameObject selectObj, bool enable)
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x7A3420", Offset = "0x7A1C20", Length = "0x276")]
	private void SetModeTitleAnim()
	{
	}

	[Address(RVA = "0x7A32F0", Offset = "0x7A1AF0", Length = "0x125")]
	[Token(Token = "0x6000857")]
	public void SetLastSelectObjTextHightlight()
	{
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x7A3130", Offset = "0x7A1930", Length = "0x1BD")]
	public void SetIsManualFever(bool isManualFever)
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x7A2E80", Offset = "0x7A1680", Length = "0xE9")]
	public void PlaySelectAudio()
	{
	}

	[Address(RVA = "0x7A4690", Offset = "0x7A2E90", Length = "0x73")]
	[Token(Token = "0x600085A")]
	public PnlInputPc()
	{
	}
}
