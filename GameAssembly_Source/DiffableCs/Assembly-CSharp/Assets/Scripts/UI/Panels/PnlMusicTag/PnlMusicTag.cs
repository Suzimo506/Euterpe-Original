namespace Assets.Scripts.UI.Panels.PnlMusicTag;

public class PnlMusicTag : AbstractTabContainer
{
	public const int event_on_rect_moved = 2; //Field offset: 0x0
	public const int event_on_ok_click = 0; //Field offset: 0x0
	public const int event_update_header = 3; //Field offset: 0x0
	public const ulong add_or_remove_hide_like = 2147483648; //Field offset: 0x0
	public const int tab_music_tag = 0; //Field offset: 0x0
	public const int tab_difficulty_filter = 1; //Field offset: 0x0
	public const int tab_search = 2; //Field offset: 0x0
	public const int event_bg_cancel_click = 1; //Field offset: 0x0
	[SerializeField]
	private PnlMusicTagScrollView m_ScrollView; //Field offset: 0x148
	[SerializeField]
	private RectTransform m_TagMoveTransform; //Field offset: 0x150
	[SerializeField]
	private GameObject m_PcKeyTip; //Field offset: 0x158
	[SerializeField]
	private Button m_Ok; //Field offset: 0x160
	[SerializeField]
	private GameObject m_NoMusicTip; //Field offset: 0x168
	private Text m_NoMusicTipTxt; //Field offset: 0x170
	[SerializeField]
	private Button[] m_CloseButtons; //Field offset: 0x178
	private Tweener m_ItemMoveTweener; //Field offset: 0x180
	[SerializeField]
	private MusicButtonAreaTitle m_HeaderTitle; //Field offset: 0x188
	private int m_HeaderTreeIndex; //Field offset: 0x190
	[SerializeField]
	private RectTransform m_HeaderTitleRect; //Field offset: 0x198
	private float m_HeaderWidth; //Field offset: 0x1A0
	[SerializeField]
	private RectTransform m_BgTrans; //Field offset: 0x1A8
	[SerializeField]
	private GameObject m_AnchorLiveModeObj; //Field offset: 0x1B0
	[SerializeField]
	private Toggle m_AnchorShowTgl; //Field offset: 0x1B8
	[SerializeField]
	private Popup m_Popup; //Field offset: 0x1C0
	private bool m_Init; //Field offset: 0x1C8
	private AbstractTreeViewItemMgr m_DataMgr; //Field offset: 0x1D0

	private AbstractTabItem curTabItem
	{
		private get { } //Length: 59
	}

	public int fixedCount
	{
		 get { } //Length: 32
	}

	public List<PnlMusicTagViewItem> viewItems
	{
		 get { } //Length: 66
	}

	public PnlMusicTag() { }

	private void ChangedScale() { }

	public void Close() { }

	protected virtual void Destroy() { }

	private AbstractTabItem get_curTabItem() { }

	public int get_fixedCount() { }

	public List<PnlMusicTagViewItem> get_viewItems() { }

	private void InitAnchorUi() { }

	private void InitBaseUi() { }

	private void InitGlobalEventHandler() { }

	protected virtual void InitTabContainer() { }

	public virtual bool InvokeEvent(int eventIndex) { }

	private void OnAddRemoveHideOrLike(object sender, object rev, Object[] args) { }

	private void OnAnchorChanged(object sender, object rev, Object[] args) { }

	private void OnAnchorTglValueChanged(bool isOn) { }

	public virtual void OnAwake() { }

	private void OnBgShutClicked() { }

	public void OnCellClicked(MusicButtonCell cell, int clickCount) { }

	public virtual void OnEnablePnl() { }

	private void OnEnableSetAnchorUi() { }

	private void OnLanguageChanged(int languageIndex) { }

	private void OnLevelUp(object sender, object rev, Object[] args) { }

	private void OnOkClicked() { }

	private void OnScrollContentPosChanged(Vector2 pos) { }

	private void OnScrollViewMoved() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual void OnUpdatePnl() { }

	private void PlayFuncButtonToggleAnim(int index, float normalizeTime = 0) { }

	public void RefreshAllShownItem() { }

	public void RefreshScrollViewItem() { }

	public void SetContentData(AbstractTreeViewItemMgr mgr, Func<LoopListView2`1<PnlMusicTagViewItem>, Int32, PnlMusicTagViewItem> getItemByIndexCallback) { }

	private void SetDiffUiByPlatform() { }

	public void SetNoMusicTip(bool enable) { }

	public virtual bool SetTabIndex(int tabIndex) { }

	public void Show() { }

}

