namespace SuperScrollView;

public class ItemPool
{
	private static int mCurItemIdCount; //Field offset: 0x0
	private ItemPrefabConfData m_ConfData; //Field offset: 0x0
	private List<T> mTmpPooledItemList; //Field offset: 0x0
	private List<T> mPooledItemList; //Field offset: 0x0
	private RectTransform mItemParent; //Field offset: 0x0
	private List<T> mCachePoolItems; //Field offset: 0x0

	public GameObject poolGameObject
	{
		 get { } //Length: 27
	}

	private static ItemPool`1() { }

	public ItemPool`1() { }

	public void ClearTmpRecycledItem() { }

	public T CreateItem() { }

	public void DestroyAllItem() { }

	public GameObject get_poolGameObject() { }

	public T GetItem() { }

	public void Init(ItemPrefabConfData confData, RectTransform parent) { }

	public void RecycleItem(T item) { }

	private void RecycleItemReal(T item) { }

	public void UpdateConfig() { }

}

