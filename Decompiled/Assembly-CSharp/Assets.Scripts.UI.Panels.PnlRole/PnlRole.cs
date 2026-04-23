using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.UI.Controls;
using Assets.Scripts.UI.Redot.RoleSelectRedot;
using Assets.Scripts.UI.Tips;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200095E")]
public class PnlRole : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003322")]
	[SerializeField]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003323")]
	[SerializeField]
	private SelectableFancyPanel m_FancyPanel;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003324")]
	[SerializeField]
	private GameObject m_FancyPanelCell;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003325")]
	[SerializeField]
	private BtnCharacterSpecial m_BtnCharacterSpecial;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003326")]
	private DBConfigCharacter m_ConfigCharacter;

	[Token(Token = "0x4003327")]
	[FieldOffset(Offset = "0x40")]
	private Assets.Scripts.Database.CharacterInfo m_CurrentCharacterInfo;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003328")]
	private LocalCharacterInfo m_CurrentLocalCharacterInfo;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4003329")]
	private IData m_CurrentCharacterItem;

	[Token(Token = "0x400332A")]
	private static List<int> s_ValidRoleOrder;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400332B")]
	public int m_CurCellIndex;

	[Token(Token = "0x400332C")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private PnlRoleTalkBubble m_TalkBubble;

	[SerializeField]
	[Token(Token = "0x400332D")]
	[FieldOffset(Offset = "0x68")]
	private PnlRoleSkinContainer m_SkinContainer;

	[SerializeField]
	[Token(Token = "0x400332E")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_TxtSkinTipsObj;

	[Token(Token = "0x400332F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text m_TxtSkinTips;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9770", Offset = "0x8B70")]
	[SerializeField]
	[Token(Token = "0x4003330")]
	[FieldOffset(Offset = "0x80")]
	private Text m_TxtCv;

	[SerializeField]
	[Token(Token = "0x4003331")]
	[FieldOffset(Offset = "0x88")]
	private Text m_TxtHp;

	[Token(Token = "0x4003332")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text m_TxtCosName;

	[SerializeField]
	[Token(Token = "0x4003333")]
	[FieldOffset(Offset = "0x98")]
	private Text m_TxtCharName;

	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4003334")]
	private PnlRoleScrollTxtFitter m_TxtSkillFitter;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4003335")]
	public Action onRoleChange;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4003336")]
	[SerializeField]
	private PnlRoleMainShowControl m_MainShow;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4003337")]
	[SerializeField]
	private PnlRoleNavigationShowControl m_NavigationShow;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4003338")]
	[SerializeField]
	private Button m_BtnNavigation;

	[SerializeField]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4003339")]
	private RolePreviewsEntryRedot m_RolePreviewsEntryRedot;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400333C")]
	private BtnApply.ButtonState m_CurrentButtonState;

	[Token(Token = "0x400333D")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_IsInit;

	[Token(Token = "0x400333E")]
	public const string silencer_default_hp = "250";

	[Token(Token = "0x400333F")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine m_EndCoroutine;

	[Token(Token = "0x4003340")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_IsFinishAnim;

	[Token(Token = "0x4003341")]
	[FieldOffset(Offset = "0xF8")]
	private Action m_EndCallback;

	[Token(Token = "0x4003342")]
	[FieldOffset(Offset = "0x100")]
	private CharacterApply m_PrevTalkApply;

	[Token(Token = "0x170008F3")]
	public PnlRoleScrollTxtFitter RoleScrollTxtFitter
	{
		[Address(RVA = "0x48E690", Offset = "0x48CE90", Length = "0x8")]
		[Token(Token = "0x6005531")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F4")]
	public Text TxtHp
	{
		[Address(RVA = "0x5C1450", Offset = "0x5BFC50", Length = "0x8")]
		[Token(Token = "0x6005532")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F5")]
	public Assets.Scripts.Database.CharacterInfo currCharacterInfo
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6005533")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F6")]
	public SelectableFancyPanel fancyPanel
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x6005534")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F7")]
	public bool isFinishAnim
	{
		[Address(RVA = "0x6497D0", Offset = "0x647FD0", Length = "0x8")]
		[Token(Token = "0x6005556")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000099")]
	public event Action<int, int> onApplyRole
	{
		[Address(RVA = "0x649730", Offset = "0x647F30", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6005535")]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x649880", Offset = "0x648080", Length = "0x9E")]
		[Token(Token = "0x6005536")]
		remove
		{
		}
	}

	[Token(Token = "0x1400009A")]
	public event Action onApplyRoleEnd
	{
		[Token(Token = "0x6005537")]
		[CompilerGenerated]
		[Address(RVA = "0x649690", Offset = "0x647E90", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x6497E0", Offset = "0x647FE0", Length = "0x9E")]
		[Token(Token = "0x6005538")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Address(RVA = "0x6459A0", Offset = "0x6441A0", Length = "0x2A6")]
	[Token(Token = "0x6005539")]
	private void Init()
	{
	}

	[Token(Token = "0x600553A")]
	[Address(RVA = "0x6480E0", Offset = "0x6468E0", Length = "0x290")]
	private void RegisterEvent()
	{
	}

	[Token(Token = "0x600553B")]
	[Address(RVA = "0x649000", Offset = "0x647800", Length = "0x290")]
	private void UnregisterEvent()
	{
	}

	[Address(RVA = "0x646B10", Offset = "0x645310", Length = "0x7")]
	[Token(Token = "0x600553C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600553D")]
	[Address(RVA = "0x646BC0", Offset = "0x6453C0", Length = "0x280")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600553E")]
	[Address(RVA = "0x646B20", Offset = "0x645320", Length = "0x93")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600553F")]
	[Address(RVA = "0x647280", Offset = "0x645A80", Length = "0x70")]
	private void OnPnlDlcOut()
	{
	}

	[Token(Token = "0x6005540")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnBackToLobby()
	{
	}

	[Token(Token = "0x6005541")]
	[Address(RVA = "0x6475B0", Offset = "0x645DB0", Length = "0x2C1")]
	private void RebuildCharacterFSV()
	{
	}

	[Address(RVA = "0x645080", Offset = "0x643880", Length = "0x158")]
	[Token(Token = "0x6005542")]
	private int GetPreviousOrder()
	{
		return default(int);
	}

	[Address(RVA = "0x6457C0", Offset = "0x643FC0", Length = "0x124")]
	[Token(Token = "0x6005543")]
	private bool HasBaseNewUnlockedItems()
	{
		return default(bool);
	}

	[Address(RVA = "0x644EC0", Offset = "0x6436C0", Length = "0x1B0")]
	[Token(Token = "0x6005544")]
	private Assets.Scripts.Database.CharacterInfo GetNewRole()
	{
		return null;
	}

	[Address(RVA = "0x648840", Offset = "0x647040", Length = "0x121")]
	[Token(Token = "0x6005545")]
	private void ShowNewRolePopInfo(int roleIdx)
	{
	}

	[Token(Token = "0x6005546")]
	[Address(RVA = "0x648380", Offset = "0x646B80", Length = "0x1C3")]
	private void ScrollToVersionNewRole()
	{
	}

	[Address(RVA = "0x647AE0", Offset = "0x6462E0", Length = "0x102")]
	[Token(Token = "0x6005547")]
	private void RefreshRoleFocusState(int scrollIdx)
	{
	}

	[Address(RVA = "0x647E60", Offset = "0x646660", Length = "0x278")]
	[Token(Token = "0x6005548")]
	private void RefreshValidRoleList()
	{
	}

	[Address(RVA = "0x647A60", Offset = "0x646260", Length = "0x75")]
	[Token(Token = "0x6005549")]
	public void RefreshRedotState()
	{
	}

	[Address(RVA = "0x647430", Offset = "0x645C30", Length = "0x173")]
	[Token(Token = "0x600554A")]
	public void PlayCharacterBgm(int i)
	{
	}

	[Token(Token = "0x600554B")]
	[Address(RVA = "0x647050", Offset = "0x645850", Length = "0x227")]
	private void OnFsvIndexChanged(int index)
	{
	}

	[Address(RVA = "0x646E50", Offset = "0x645650", Length = "0x1F8")]
	[Token(Token = "0x600554C")]
	private void OnFsvFinalIndexChange(int index)
	{
	}

	[Address(RVA = "0x6462E0", Offset = "0x644AE0", Length = "0xEA")]
	[Token(Token = "0x600554D")]
	private void ItemTimeoutCheck(int index)
	{
	}

	[Address(RVA = "0x6492A0", Offset = "0x647AA0", Length = "0x110")]
	[Token(Token = "0x600554E")]
	private bool VipTimeoutCheck()
	{
		return default(bool);
	}

	[Address(RVA = "0x647880", Offset = "0x646080", Length = "0x3D")]
	[Token(Token = "0x600554F")]
	private void RefreshAfterPurchased()
	{
	}

	[Token(Token = "0x6005550")]
	[Address(RVA = "0x646280", Offset = "0x644A80", Length = "0x53")]
	private bool IsSelectedRole(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x648550", Offset = "0x646D50", Length = "0x2E4")]
	[Token(Token = "0x6005551")]
	private void SetProperties()
	{
	}

	[Address(RVA = "0x6458F0", Offset = "0x6440F0", Length = "0xA6")]
	[Token(Token = "0x6005552")]
	private string HpDesHandler(int elfinIndex, Assets.Scripts.Database.CharacterInfo charInfo)
	{
		return null;
	}

	[Address(RVA = "0x648AF0", Offset = "0x6472F0", Length = "0xD0")]
	[Token(Token = "0x6005553")]
	private string SkillDesHandler(Assets.Scripts.Database.CharacterInfo charInfo, LocalCharacterInfo localCharInfo, int skinIndex, int elfinIndex)
	{
		return null;
	}

	[Token(Token = "0x6005554")]
	[Address(RVA = "0x647BF0", Offset = "0x6463F0", Length = "0x26D")]
	private void RefreshTryOutTips()
	{
	}

	[Token(Token = "0x6005555")]
	[Address(RVA = "0x6478C0", Offset = "0x6460C0", Length = "0x199")]
	private BtnApply.ButtonState RefreshButtonState()
	{
		return default(BtnApply.ButtonState);
	}

	[Token(Token = "0x6005557")]
	[Address(RVA = "0x644B90", Offset = "0x643390", Length = "0xFA")]
	private void Clean()
	{
	}

	[Address(RVA = "0x645710", Offset = "0x643F10", Length = "0xAB")]
	[Token(Token = "0x6005558")]
	private string GetTalkText(int index)
	{
		return null;
	}

	[Token(Token = "0x6005559")]
	[Address(RVA = "0x6451E0", Offset = "0x6439E0", Length = "0x83")]
	public static int GetRoleOrderByCellIndex(int cellIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600555A")]
	[Address(RVA = "0x645C50", Offset = "0x644450", Length = "0x62C")]
	public void InvokeTalk(int roleIdx, string animName, string voiceName, bool force = true, Action endCallback = null, bool autoAddSuffix = true, bool isEnd = true, bool isShowTxt = true, float endTime = 0f)
	{
	}

	[Token(Token = "0x600555B")]
	[Address(RVA = "0x648CA0", Offset = "0x6474A0", Length = "0x20D")]
	private void TalkEndCallback()
	{
	}

	[Token(Token = "0x600555C")]
	[Address(RVA = "0x644C90", Offset = "0x643490", Length = "0x33")]
	public void CloseTalkBubble()
	{
	}

	[Token(Token = "0x600555D")]
	[Address(RVA = "0x648970", Offset = "0x647170", Length = "0x171")]
	private void ShowSkinTipMessage()
	{
	}

	[Address(RVA = "0x645270", Offset = "0x643A70", Length = "0x490")]
	[Token(Token = "0x600555E")]
	private AbstractMessageBox GetRoleTipMessage()
	{
		return null;
	}

	[Address(RVA = "0x6464E0", Offset = "0x644CE0", Length = "0x1F0")]
	[Token(Token = "0x600555F")]
	private void JumpToDlc(int roleIndex)
	{
	}

	[Address(RVA = "0x6472F0", Offset = "0x645AF0", Length = "0x131")]
	[Token(Token = "0x6005560")]
	private void OpenAskPurchaseExtraProduct(int roleIndex)
	{
	}

	[Token(Token = "0x6005561")]
	[Address(RVA = "0x6466E0", Offset = "0x644EE0", Length = "0x344")]
	private void OnApplyClicked()
	{
	}

	[Token(Token = "0x6005562")]
	[Address(RVA = "0x644D50", Offset = "0x643550", Length = "0x161")]
	public void DoLockedBtnApplyInNavigation(BtnApply.ButtonState state, int characterIndex)
	{
	}

	[Token(Token = "0x6005563")]
	[Address(RVA = "0x6463D0", Offset = "0x644BD0", Length = "0x10E")]
	public void JumpToCharacterByIndex(int index, bool apply)
	{
	}

	[Token(Token = "0x6005564")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBF80", Offset = "0xB380")]
	[Address(RVA = "0x644CD0", Offset = "0x6434D0", Length = "0x76")]
	private IEnumerator DelayBtnApplyInvoke(bool apply)
	{
		return null;
	}

	[Token(Token = "0x6005565")]
	[Address(RVA = "0x644B20", Offset = "0x643320", Length = "0x6C")]
	public void BtnApplyInvoke()
	{
	}

	[Token(Token = "0x6005566")]
	[Address(RVA = "0x648BD0", Offset = "0x6473D0", Length = "0xC9")]
	private void SkinSwitchedCallback(PnlRoleSubControl control)
	{
	}

	[Address(RVA = "0x646A40", Offset = "0x645240", Length = "0xCA")]
	[Token(Token = "0x6005567")]
	private void OnClickSetElfinRandom()
	{
	}

	[Address(RVA = "0x649420", Offset = "0x647C20", Length = "0x265")]
	[Token(Token = "0x6005568")]
	public PnlRole()
	{
	}
}
