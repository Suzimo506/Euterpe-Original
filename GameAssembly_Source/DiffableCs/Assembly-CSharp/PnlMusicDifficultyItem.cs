//Type is in global namespace

public class PnlMusicDifficultyItem : AbstractTabItemGenerics<PnlMusicTag>
{
	protected const int pc = 0; //Field offset: 0x0
	protected const int mobile = 1; //Field offset: 0x0
	[SerializeField]
	protected GameObject[] m_DiffUi; //Field offset: 0x98
	[SerializeField]
	protected FancyScrollView[] m_CurMinDiffUiFsv; //Field offset: 0xA0
	[SerializeField]
	protected FancyScrollView[] m_CurMaxDiffUiFsv; //Field offset: 0xA8
	protected int m_UiIndex; //Field offset: 0xB0
	[SerializeField]
	protected FsvCompsFromUi[] m_Fsvs; //Field offset: 0xB8
	private BaseTreeViewItemMgr<PnlMusicDiffTreeItem> m_TreeDataMgr; //Field offset: 0xC0
	protected Dictionary<Int32, List`1<MusicInfo>> m_DiffDic; //Field offset: 0xC8
	protected FancyScrollView m_CurMinFsv; //Field offset: 0xD0
	protected FancyScrollView m_CurMaxFsv; //Field offset: 0xD8

	public virtual GameObject defaultSelectedObject
	{
		 get { } //Length: 44
	}

	public PnlMusicDifficultyItem() { }

	private void AddData(int i) { }

	protected virtual void DirtyHandler() { }

	public virtual GameObject get_defaultSelectedObject() { }

	public virtual string GetAreaTitle(int treeIndex) { }

	private MusicInfo GetMusicInfoByDiff(int diff, int index) { }

	public virtual void InitBaseUiAndData(int curIndex) { }

	public virtual bool InvokeEvent(int eventType) { }

	private void MgrDataToList(List<String> buffer) { }

	private void OnDiffValueChanged(Vector2Int value) { }

	private PnlMusicTagViewItem OnGetItemByIndex(LoopListView2<PnlMusicTagViewItem> listView, int index) { }

	public virtual void OnItemChanged(int prevIndex, int curIndex, bool init = false) { }

	private void OnMaxValueChanged(int index) { }

	private void OnMinValueChanged(int index) { }

	public virtual bool OnSelect(GameObject currentObj) { }

	private void RefreshData() { }

	private void SelectObjectChanged(bool isThis) { }

	private void SetNavigation() { }

}

