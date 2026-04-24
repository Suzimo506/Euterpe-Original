using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;
using DG.Tweening;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlMusicTag;

[Token(Token = "0x2000901")]
public class PnlMusicTag : AbstractTabContainer
{
	[Token(Token = "0x400303C")]
	private const float difficulty_panel_base_height = 795f;

	[Token(Token = "0x400303D")]
	private const float difficulty_top_display_area_height = 350f;

	[Token(Token = "0x400303E")]
	private const float difficulty_panel_anchor_mode_height = 875f;

	[Token(Token = "0x400303F")]
	private const float other_panel_base_height = 735f;

	[Token(Token = "0x4003040")]
	private const float other_top_display_area_height = 280f;

	[Token(Token = "0x4003041")]
	private const float other_panel_anchor_mode_height = 805f;

	[Token(Token = "0x4003042")]
	[SerializeField]
	[FieldOffset(Offset = "0x150")]
	private PnlMusicTagScrollView m_ScrollView;

	[Token(Token = "0x4003043")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private RectTransform m_TagMoveTransform;

	[SerializeField]
	[Token(Token = "0x4003044")]
	[FieldOffset(Offset = "0x160")]
	private GameObject m_PcKeyTip;

	[SerializeField]
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4003045")]
	private GameObject m_PcTrashCanTip;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4003046")]
	[SerializeField]
	private Button m_Ok;

	[Token(Token = "0x4003047")]
	[SerializeField]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_NoMusicTip;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4003048")]
	[SerializeField]
	private PnlMusicDifficultyFilter m_DifficultyFilter;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4003049")]
	[SerializeField]
	private RectTransform m_TopDisplayAreaTrans;

	[Token(Token = "0x400304A")]
	[FieldOffset(Offset = "0x190")]
	private Text m_NoMusicTipTxt;

	[SerializeField]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x400304B")]
	private Button[] m_CloseButtons;

	[Token(Token = "0x400304C")]
	[FieldOffset(Offset = "0x1A0")]
	private Tweener m_ItemMoveTweener;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400304D")]
	[SerializeField]
	private MusicButtonAreaTitle m_HeaderTitle;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400304E")]
	private int m_HeaderTreeIndex;

	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x400304F")]
	private RectTransform m_HeaderTitleRect;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4003050")]
	private float m_HeaderWidth;

	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4003051")]
	private bool m_SearchLock;

	[SerializeField]
	[Token(Token = "0x4003052")]
	[FieldOffset(Offset = "0x1C8")]
	private RectTransform m_BgTrans;

	[SerializeField]
	[Token(Token = "0x4003053")]
	[FieldOffset(Offset = "0x1D0")]
	private GameObject m_AnchorLiveModeObj;

	[SerializeField]
	[Token(Token = "0x4003054")]
	[FieldOffset(Offset = "0x1D8")]
	private Toggle m_AnchorShowTgl;

	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4003055")]
	[SerializeField]
	private Popup m_Popup;

	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4003056")]
	private bool m_Init;

	[FieldOffset(Offset = "0x1E9")]
	[Token(Token = "0x4003057")]
	private bool m_NoMusicTipActive;

	[Token(Token = "0x4003058")]
	[FieldOffset(Offset = "0x1EC")]
	private TagItemClickType m_LastClickItemType;

	[Token(Token = "0x4003059")]
	public const int event_on_ok_click = 0;

	[Token(Token = "0x400305A")]
	public const int event_bg_cancel_click = 1;

	[Token(Token = "0x400305B")]
	public const int event_on_rect_moved = 2;

	[Token(Token = "0x400305C")]
	public const int event_update_header = 3;

	[Token(Token = "0x400305D")]
	public const ulong add_or_remove_hide_like = 2147483648uL;

	[Token(Token = "0x400305E")]
	public const int tab_music_tag = 0;

	[Token(Token = "0x400305F")]
	public const int tab_difficulty_filter = 1;

	[Token(Token = "0x4003060")]
	public const int tab_search = 2;

	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4003061")]
	private DateTime m_PlayerInDatatime;

	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4003062")]
	private string m_InModuleMessage;

	[Token(Token = "0x4003063")]
	private const string music_label = "歌\ufffd";

	[Token(Token = "0x4003064")]
	private const string diffculty_filter = "难\ufffd";

	[Token(Token = "0x4003065")]
	private const string search = "\ufffd";

	[Token(Token = "0x4003066")]
	[FieldOffset(Offset = "0x200")]
	private AbstractTreeViewItemMgr m_DataMgr;

	[Token(Token = "0x170008B0")]
	public PnlMusicDifficultyFilter DifficultyFilter
	{
		[Address(RVA = "0x682270", Offset = "0x680A70", Length = "0x8")]
		[Token(Token = "0x60051B3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B1")]
	public int headerTreeIndex
	{
		[Token(Token = "0x60051B4")]
		[Address(RVA = "0x6822F0", Offset = "0x680AF0", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x682360", Offset = "0x680B60", Length = "0xC1")]
		[Token(Token = "0x60051B5")]
		set
		{
		}
	}

	[Token(Token = "0x170008B2")]
	public List<PnlMusicTagViewItem> viewItems
	{
		[Address(RVA = "0x682310", Offset = "0x680B10", Length = "0x42")]
		[Token(Token = "0x60051B6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B3")]
	public int fixedCount
	{
		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x6822C0", Offset = "0x680AC0", Length = "0x20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008B4")]
	private AbstractTabItem curTabItem
	{
		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x682280", Offset = "0x680A80", Length = "0x3B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B5")]
	public TagItemClickType lastClickItemType
	{
		[Address(RVA = "0x682300", Offset = "0x680B00", Length = "0x7")]
		[Token(Token = "0x60051B9")]
		get
		{
			return default(TagItemClickType);
		}
	}

	[Token(Token = "0x60051BA")]
	[Address(RVA = "0x680B70", Offset = "0x67F370", Length = "0x57")]
	private void OnEnableSetAnchorUi()
	{
	}

	[Address(RVA = "0x67F910", Offset = "0x67E110", Length = "0x138")]
	[Token(Token = "0x60051BB")]
	private void InitAnchorUi()
	{
	}

	[Address(RVA = "0x680000", Offset = "0x67E800", Length = "0xC7")]
	[Token(Token = "0x60051BC")]
	private void OnAnchorTglValueChanged(bool isOn)
	{
	}

	[Address(RVA = "0x67FFE0", Offset = "0x67E7E0", Length = "0x1A")]
	[Token(Token = "0x60051BD")]
	private void OnAnchorChanged(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x6800D0", Offset = "0x67E8D0", Length = "0x55B")]
	[Token(Token = "0x60051BE")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60051BF")]
	[Address(RVA = "0x680630", Offset = "0x67EE30", Length = "0x37")]
	private void OnBgShutClicked()
	{
	}

	[Address(RVA = "0x680FC0", Offset = "0x67F7C0", Length = "0x16")]
	[Token(Token = "0x60051C0")]
	private void OnScrollContentPosChanged(Vector2 pos)
	{
	}

	[Token(Token = "0x60051C1")]
	[Address(RVA = "0x67FEE0", Offset = "0x67E6E0", Length = "0x72")]
	protected override void InitTabContainer()
	{
	}

	[Token(Token = "0x60051C2")]
	[Address(RVA = "0x67FD60", Offset = "0x67E560", Length = "0x175")]
	private void InitGlobalEventHandler()
	{
	}

	[Token(Token = "0x60051C3")]
	[Address(RVA = "0x67F5F0", Offset = "0x67DDF0", Length = "0x1FD")]
	protected override void Destroy()
	{
	}

	[Address(RVA = "0x680BD0", Offset = "0x67F3D0", Length = "0x1A")]
	[Token(Token = "0x60051C4")]
	private void OnLanguageChanged(int languageIndex)
	{
	}

	[Address(RVA = "0x680BF0", Offset = "0x67F3F0", Length = "0x1A")]
	[Token(Token = "0x60051C5")]
	private void OnLevelUp(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x67FFC0", Offset = "0x67E7C0", Length = "0x1C")]
	[Token(Token = "0x60051C6")]
	private void OnAddRemoveHideOrLike(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x680980", Offset = "0x67F180", Length = "0x1E5")]
	[Token(Token = "0x60051C7")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x680670", Offset = "0x67EE70", Length = "0x309")]
	[Token(Token = "0x60051C8")]
	public void OnCellClicked(MusicButtonCell cell, int clickCount)
	{
	}

	[Token(Token = "0x60051C9")]
	[Address(RVA = "0x680C10", Offset = "0x67F410", Length = "0x11")]
	public void OnMusicTagClicked()
	{
	}

	[Token(Token = "0x60051CA")]
	[Address(RVA = "0x681E10", Offset = "0x680610", Length = "0x4C")]
	public void SetNoMusicTip(bool enable, int tabIndex = -1)
	{
	}

	[Token(Token = "0x60051CB")]
	[Address(RVA = "0x67F7F0", Offset = "0x67DFF0", Length = "0x90")]
	public void FreshNoMusicText()
	{
	}

	[Token(Token = "0x60051CC")]
	[Address(RVA = "0x682110", Offset = "0x680910", Length = "0x131")]
	public void Show()
	{
	}

	[Token(Token = "0x60051CD")]
	[Address(RVA = "0x67F510", Offset = "0x67DD10", Length = "0xD8")]
	public void Close()
	{
	}

	[Token(Token = "0x60051CE")]
	[Address(RVA = "0x67F890", Offset = "0x67E090", Length = "0x76")]
	public string GetCurModuleMessage()
	{
		return null;
	}

	[Token(Token = "0x60051CF")]
	[Address(RVA = "0x67FF60", Offset = "0x67E760", Length = "0x56")]
	public override bool InvokeEvent(int eventIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x680FE0", Offset = "0x67F7E0", Length = "0x474")]
	[Token(Token = "0x60051D0")]
	private void OnScrollViewMoved()
	{
	}

	[Address(RVA = "0x681E60", Offset = "0x680660", Length = "0x7")]
	[Token(Token = "0x60051D1")]
	public void SetSearchLock(bool isLock)
	{
	}

	[Address(RVA = "0x680C30", Offset = "0x67F430", Length = "0x381")]
	[Token(Token = "0x60051D2")]
	public void OnOkClicked()
	{
	}

	[Address(RVA = "0x67FA50", Offset = "0x67E250", Length = "0x309")]
	[Token(Token = "0x60051D3")]
	private void InitBaseUi()
	{
	}

	[Token(Token = "0x60051D4")]
	[Address(RVA = "0x681D30", Offset = "0x680530", Length = "0x9A")]
	public void SetContentData(AbstractTreeViewItemMgr mgr, Func<LoopListView2<PnlMusicTagViewItem>, int, PnlMusicTagViewItem> getItemByIndexCallback)
	{
	}

	[Address(RVA = "0x681CB0", Offset = "0x6804B0", Length = "0x74")]
	[Token(Token = "0x60051D5")]
	public void RefreshScrollViewItem()
	{
	}

	[Address(RVA = "0x681960", Offset = "0x680160", Length = "0x5F")]
	[Token(Token = "0x60051D6")]
	public void RefreshAllShownItem()
	{
	}

	[Address(RVA = "0x681DD0", Offset = "0x6805D0", Length = "0x3F")]
	[Token(Token = "0x60051D7")]
	private void SetDiffUiByPlatform()
	{
	}

	[Token(Token = "0x60051D8")]
	[Address(RVA = "0x67F460", Offset = "0x67DC60", Length = "0xA6")]
	private void ChangedScale()
	{
	}

	[Token(Token = "0x60051D9")]
	[Address(RVA = "0x681E70", Offset = "0x680670", Length = "0x294")]
	public override bool SetTabIndex(int tabIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60051DA")]
	[Address(RVA = "0x6818A0", Offset = "0x6800A0", Length = "0xB5")]
	private void PlayFuncButtonToggleAnim(int index, float normalizeTime = 0f)
	{
	}

	[Address(RVA = "0x681660", Offset = "0x67FE60", Length = "0x23F")]
	[Token(Token = "0x60051DB")]
	public override void OnUpdatePnl()
	{
	}

	[Token(Token = "0x60051DC")]
	[Address(RVA = "0x681460", Offset = "0x67FC60", Length = "0x1F4")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60051DD")]
	[Address(RVA = "0x67F400", Offset = "0x67DC00", Length = "0x55")]
	public void AddExtraSelectableObjs(List<GameObject> selectables)
	{
	}

	[Token(Token = "0x60051DE")]
	[Address(RVA = "0x6819C0", Offset = "0x6801C0", Length = "0x186")]
	public void RefreshDifficultyTabUILayout(bool isAdditionalSettingOn)
	{
	}

	[Address(RVA = "0x681B50", Offset = "0x680350", Length = "0x15B")]
	[Token(Token = "0x60051DF")]
	private void RefreshOtherTabUILayout()
	{
	}

	[Address(RVA = "0x682250", Offset = "0x680A50", Length = "0x11")]
	[Token(Token = "0x60051E0")]
	public PnlMusicTag()
	{
	}
}
