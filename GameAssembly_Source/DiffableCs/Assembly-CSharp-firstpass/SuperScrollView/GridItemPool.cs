namespace SuperScrollView;

public class GridItemPool
{
	private static int mCurItemIdCount; //Field offset: 0x0
	private GameObject mPrefabObj; //Field offset: 0x10
	private string mPrefabName; //Field offset: 0x18
	private int mInitCreateCount; //Field offset: 0x20
	private List<LoopGridViewItem> mTmpPooledItemList; //Field offset: 0x28
	private List<LoopGridViewItem> mPooledItemList; //Field offset: 0x30
	private RectTransform mItemParent; //Field offset: 0x38

	private static GridItemPool() { }

	public GridItemPool() { }

	public void ClearTmpRecycledItem() { }

	public LoopGridViewItem CreateItem() { }

	public void DestroyAllItem() { }

	public LoopGridViewItem GetItem() { }

	public void Init(GameObject prefabObj, int createCount, RectTransform parent) { }

	public void RecycleItem(LoopGridViewItem item) { }

	private void RecycleItemReal(LoopGridViewItem item) { }

}

