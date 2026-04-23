using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.Structs;
using Assets.Scripts.UI.Panels;
using Assets.Scripts.UI.Panels.PnlRole;
using Assets.Scripts.UI.Redot.RoleSelectRedot;
using Assets.Scripts.UI.Tips;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000115")]
public class PnlElfin : MonoBehaviour, ILevelConfigUI
{
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x20")]
	private SelectableFancyPanel m_FancyPanel;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006AF")]
	private GameObject m_FancyPanelCell;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006B0")]
	private DBConfigElfin m_ConfigElfin;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006B1")]
	private ElfinInfo m_CurElfineInfo;

	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x40")]
	private IData m_CurrentElfinItem;

	[Token(Token = "0x40006B3")]
	private static List<int> s_ValidElfinOrder;

	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006B4")]
	private AudioClip m_MenuClip;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9770", Offset = "0x8B70")]
	[Token(Token = "0x40006B5")]
	private Text m_TxtElfinName;

	[SerializeField]
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x58")]
	private PnlRoleScrollTxtFitter m_TxtSkill;

	[SerializeField]
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x60")]
	private Text m_TxtDescription;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006B8")]
	private BtnApply.ButtonState m_CurrentButtonState;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x6C")]
	private int m_SelectToggleIndex;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x70")]
	private List<ElfinItemData> m_CurNavigationElfinItemDatas;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006BB")]
	public GameObject mainShowObj;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40006BC")]
	public GameObject navigationObj;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40006BD")]
	public ElfinGridView elfinGridView;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40006BE")]
	private Dictionary<ElfinType, List<ElfinItemData>> m_DicElfinItemDatas;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40006BF")]
	public Button btnNavigation;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40006C0")]
	public Button btnLeaveNavigation;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1B690", Offset = "0x1AA90")]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40006C1")]
	public List<Toggle> elfinToggles;

	[Token(Token = "0x40006C2")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1B8D0", Offset = "0x1ACD0")]
	[FieldOffset(Offset = "0xB0")]
	public List<RolePreviewRedot> elfinRedots;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40006C3")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1BA30", Offset = "0x1AE30")]
	public RolePreviewRedot elfinBtnNavigationRedot;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40006C4")]
	public PnlElfinSelect pnlElfinSelect;

	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0xC8")]
	public Button btnLove;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40006C6")]
	public Button btnChangeRandom;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40006C7")]
	public Button btnQ;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40006C8")]
	public Button btnE;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40006C9")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1BA60", Offset = "0x1AE60")]
	public RectTransform rectDesciption;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<LevelConfigUIState, int> m_DicCurCellIndexs;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40006CB")]
	private GlobalScriptableObjectData m_GlobalData;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x100")]
	private LevelConfigUIState m_CurrentUIState;

	[Token(Token = "0x40006CD")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x170000A5")]
	private int m_CurCellIndex
	{
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x503B80", Offset = "0x502380", Length = "0x8F")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x503C10", Offset = "0x502410", Length = "0x5A")]
		set
		{
		}
	}

	[Token(Token = "0x170000A6")]
	public SelectableFancyPanel fancyPanel
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x60007EB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A7")]
	public GlobalScriptableObjectData globalData
	{
		[Address(RVA = "0x503AB0", Offset = "0x5022B0", Length = "0xCB")]
		[Token(Token = "0x60007EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A8")]
	public LevelConfigUIState currentUIState
	{
		[Address(RVA = "0x4FB790", Offset = "0x4F9F90", Length = "0x7")]
		[Token(Token = "0x60007ED")]
		get
		{
			return default(LevelConfigUIState);
		}
	}

	[Address(RVA = "0x4FFE90", Offset = "0x4FE690", Length = "0x2F")]
	[Token(Token = "0x60007EE")]
	public void ChangeLevelConfigUIState(LevelConfigUIState newState)
	{
	}

	[Address(RVA = "0x4FF6E0", Offset = "0x4FDEE0", Length = "0x7A1")]
	[Token(Token = "0x60007EF")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x501D30", Offset = "0x500530", Length = "0x27D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x502050", Offset = "0x500850", Length = "0xF4")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x501FB0", Offset = "0x5007B0", Length = "0x96")]
	[Token(Token = "0x60007F2")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x5022C0", Offset = "0x500AC0", Length = "0x6C")]
	private void OnPnlDlcOut()
	{
	}

	[Address(RVA = "0x5024D0", Offset = "0x500CD0", Length = "0x1A9")]
	[Token(Token = "0x60007F4")]
	private void RebuildElfinFSV()
	{
	}

	[Address(RVA = "0x502B00", Offset = "0x501300", Length = "0x135")]
	[Token(Token = "0x60007F5")]
	private BtnApply.ButtonState RefreshButtonState()
	{
		return default(BtnApply.ButtonState);
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x5006D0", Offset = "0x4FEED0", Length = "0x1AD")]
	private int GetPreviousOrder()
	{
		return default(int);
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x502F90", Offset = "0x501790", Length = "0x356")]
	private void RefreshValidElfinList()
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x5002D0", Offset = "0x4FEAD0", Length = "0x83")]
	public static int GetElfinOrderByCellIndex(int cellIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x5001F0", Offset = "0x4FE9F0", Length = "0xD7")]
	public static int GetElfinCellIndexByElfinOrder(int order)
	{
		return default(int);
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x502400", Offset = "0x500C00", Length = "0xC9")]
	private void PlayElfinBgm()
	{
	}

	[Address(RVA = "0x5026C0", Offset = "0x500EC0", Length = "0x56")]
	[Token(Token = "0x60007FB")]
	private void RefreshAfterPurchased()
	{
	}

	[Address(RVA = "0x502680", Offset = "0x500E80", Length = "0x36")]
	[Token(Token = "0x60007FC")]
	public void RefeshBtnApply()
	{
	}

	[Address(RVA = "0x502250", Offset = "0x500A50", Length = "0x64")]
	[Token(Token = "0x60007FD")]
	private void OnFsvIndexChanged(int index)
	{
	}

	[Address(RVA = "0x502250", Offset = "0x500A50", Length = "0x64")]
	[Token(Token = "0x60007FE")]
	public void RefreshDownBtn(int index)
	{
	}

	[Address(RVA = "0x502C40", Offset = "0x501440", Length = "0x24E")]
	[Token(Token = "0x60007FF")]
	private void RefreshCurStateDown()
	{
	}

	[Address(RVA = "0x502150", Offset = "0x500950", Length = "0xF7")]
	[Token(Token = "0x6000800")]
	private void OnFsvFinalIndexChange(int index)
	{
	}

	[Address(RVA = "0x500F80", Offset = "0x4FF780", Length = "0xEA")]
	[Token(Token = "0x6000801")]
	private void ItemTimeoutCheck(int index)
	{
	}

	[Address(RVA = "0x5037C0", Offset = "0x501FC0", Length = "0x110")]
	[Token(Token = "0x6000802")]
	private bool VipTimeoutCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0x5032F0", Offset = "0x501AF0", Length = "0x56")]
	private void SetProperties(LocalElfinInfo localElfinInfo)
	{
	}

	[Address(RVA = "0x500360", Offset = "0x4FEB60", Length = "0x369")]
	[Token(Token = "0x6000804")]
	private AbstractMessageBox GetMessageBox(int elfinIndex)
	{
		return null;
	}

	[Address(RVA = "0x501070", Offset = "0x4FF870", Length = "0x229")]
	[Token(Token = "0x6000805")]
	private void JumpToDlc(int elfinIndex)
	{
	}

	[Token(Token = "0x6000806")]
	[Address(RVA = "0x5036F0", Offset = "0x501EF0", Length = "0x95")]
	private static void ThinkingDataElfinCheck(CheckRoleItemParams iapParams)
	{
	}

	[Address(RVA = "0x501510", Offset = "0x4FFD10", Length = "0x2CF")]
	[Token(Token = "0x6000807")]
	private void OnApplyClicked()
	{
	}

	[Token(Token = "0x6000808")]
	[Address(RVA = "0x503350", Offset = "0x501B50", Length = "0xA8")]
	private void SilencerApplyHandler()
	{
	}

	[Token(Token = "0x6000809")]
	[Address(RVA = "0x5009B0", Offset = "0x4FF1B0", Length = "0x101")]
	private void InitElfinNavigationData()
	{
	}

	[Address(RVA = "0x4FFEC0", Offset = "0x4FE6C0", Length = "0x28D")]
	[Token(Token = "0x600080A")]
	private void ClearDicElfins()
	{
	}

	[Address(RVA = "0x500AC0", Offset = "0x4FF2C0", Length = "0xFF")]
	[Token(Token = "0x600080B")]
	private void InitLoveElfinToggle()
	{
	}

	[Address(RVA = "0x500E80", Offset = "0x4FF680", Length = "0xFD")]
	[Token(Token = "0x600080C")]
	private void InvokeTargetToggle(int index)
	{
	}

	[Address(RVA = "0x502330", Offset = "0x500B30", Length = "0xC7")]
	[Token(Token = "0x600080D")]
	private void OnToggleValueChange(bool isOn)
	{
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x502E90", Offset = "0x501690", Length = "0xFF")]
	private void RefreshNavPanel(bool refreshSelect = true, bool selectFirstITem = false)
	{
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x500BC0", Offset = "0x4FF3C0", Length = "0x1AE")]
	private void InitRedots()
	{
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x501970", Offset = "0x500170", Length = "0x8F")]
	private void OnClickOpenNavigation()
	{
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x5018A0", Offset = "0x5000A0", Length = "0xC5")]
	private void OnClickCloseNavigation()
	{
	}

	[Address(RVA = "0x501A00", Offset = "0x500200", Length = "0x146")]
	[Token(Token = "0x6000812")]
	private void OnClickSetElfinLove()
	{
	}

	[Address(RVA = "0x502990", Offset = "0x501190", Length = "0x165")]
	[Token(Token = "0x6000813")]
	private void RefreshBtnLoveState()
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x501B50", Offset = "0x500350", Length = "0x1D0")]
	private void OnClickSetElfinRandom()
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x502720", Offset = "0x500F20", Length = "0x263")]
	private void RefreshBtnChangeRandomState()
	{
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x501840", Offset = "0x500040", Length = "0x5D")]
	public void OnClickBtnQ()
	{
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x5017E0", Offset = "0x4FFFE0", Length = "0x5F")]
	public void OnClickBtnE()
	{
	}

	[Address(RVA = "0x503400", Offset = "0x501C00", Length = "0x2E6")]
	[Token(Token = "0x6000818")]
	private void SortCell(int index)
	{
	}

	[Address(RVA = "0x500D70", Offset = "0x4FF570", Length = "0x102")]
	[Token(Token = "0x6000819")]
	public ElfinType IntToElginType(int value)
	{
		return default(ElfinType);
	}

	[Address(RVA = "0x5012A0", Offset = "0x4FFAA0", Length = "0x266")]
	[Token(Token = "0x600081A")]
	public void JumpToSelectedCharacterWithApply(Action afterAniEnd = null)
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1BB60", Offset = "0x1AF60")]
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x500150", Offset = "0x4FE950", Length = "0x92")]
	private IEnumerator DelayBtnApplyInvoke(bool apply, Action callBack = null)
	{
		return null;
	}

	[Token(Token = "0x600081C")]
	[Address(RVA = "0x500880", Offset = "0x4FF080", Length = "0x125")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0x503980", Offset = "0x502180", Length = "0x129")]
	public PnlElfin()
	{
	}
}
