//Type is in global namespace

public class PnlMusicTagItem : AbstractTabItemGenerics<PnlMusicTag>
{
	[SerializeField]
	private GameObject m_CustomTagButton; //Field offset: 0x98
	[SerializeField]
	private ToggleGroup m_ToggleGroup; //Field offset: 0xA0
	[SerializeField]
	private Transform m_TagGroup1; //Field offset: 0xA8
	[SerializeField]
	private Transform m_TagGroup2; //Field offset: 0xB0
	private Dictionary<Int32, AlbumTagToggle> m_Toggles; //Field offset: 0xB8
	private int m_CurTagIndex; //Field offset: 0xC0
	private bool m_IsUnlockAll; //Field offset: 0xC4
	private BaseTreeViewItemMgr<PnlMusicTagTreeItem> m_TreeDataMgr; //Field offset: 0xC8
	private List<Int32> m_LockSortIndex; //Field offset: 0xD0
	private List<Int32> m_UnlockSortIndex; //Field offset: 0xD8
	private Dictionary<Int32, List`1<MusicInfo>> m_LockMusicInfos; //Field offset: 0xE0
	private Dictionary<Int32, List`1<MusicInfo>> m_UnlockMusicInfos; //Field offset: 0xE8

	public virtual GameObject defaultSelectedObject
	{
		 get { } //Length: 91
	}

	public PnlMusicTagItem() { }

	private void AddDataToMgr(int index, int count, bool isUnlock, int tagIndex = -1) { }

	private void AddSortList(int index, bool isUnlock) { }

	private void AddWeekFree() { }

	private void BaseAlbumSort(List<AlbumDisplayMusic> albums) { }

	private void ClearData() { }

	protected virtual void DirtyHandler() { }

	public virtual void Enable(int curTabIndex) { }

	public virtual GameObject get_defaultSelectedObject() { }

	public virtual string GetAreaTitle(int treeIndex) { }

	private List<MusicInfo> GetMusicInfos(int index, bool isUnlock) { }

	public virtual bool GetSelectGameObject(List<GameObject> buffer) { }

	private bool HideAndLikeTagHandler(int tagIndex) { }

	public virtual void InitBaseUiAndData(int curIndex) { }

	private void InitToggles() { }

	public virtual bool InvokeEvent(int eventType) { }

	private void MgrToUids(List<String> buffer) { }

	private void NoTitleSort(AlbumTagInfo tagInfo) { }

	private PnlMusicTagViewItem OnGetItemByIndex(LoopListView2<PnlMusicTagViewItem> listView, int index) { }

	public virtual void OnItemChanged(int prevIndex, int curIndex, bool init = false) { }

	private void OnTagClicked(int tagIndex) { }

	private void RefreshDataTitleTxt() { }

	private void RefreshTagTreeData() { }

	private void SelectObjectChanged(bool isThis) { }

	private void SetNavigation() { }

	private void ShowTip(string key) { }

	private void SortAllAlbum(List<AlbumDisplayMusic> albums) { }

}

