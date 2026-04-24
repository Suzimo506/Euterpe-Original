namespace SuperScrollView;

public class StaggeredGridItemPool
{
	private static int mCurItemIdCount; //Field offset: 0x0
	private GameObject mPrefabObj; //Field offset: 0x10
	private string mPrefabName; //Field offset: 0x18
	private int mInitCreateCount; //Field offset: 0x20
	private float mPadding; //Field offset: 0x24
	private List<LoopStaggeredGridViewItem> mTmpPooledItemList; //Field offset: 0x28
	private List<LoopStaggeredGridViewItem> mPooledItemList; //Field offset: 0x30
	private RectTransform mItemParent; //Field offset: 0x38

	private static StaggeredGridItemPool() { }

	public StaggeredGridItemPool() { }

	public void ClearTmpRecycledItem() { }

	public LoopStaggeredGridViewItem CreateItem() { }

	public void DestroyAllItem() { }

	public LoopStaggeredGridViewItem GetItem() { }

	public void Init(GameObject prefabObj, float padding, int createCount, RectTransform parent) { }

	public void RecycleItem(LoopStaggeredGridViewItem item) { }

	private void RecycleItemReal(LoopStaggeredGridViewItem item) { }

}

