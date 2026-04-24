namespace SuperScrollView;

public class ItemPosMgr
{
	public const int mItemMaxCountPerGroup = 100; //Field offset: 0x0
	private List<ItemSizeGroup> mItemSizeGroupList; //Field offset: 0x10
	private int mDirtyBeginIndex; //Field offset: 0x18
	public float mTotalSize; //Field offset: 0x1C
	public float mItemDefaultSize; //Field offset: 0x20
	private int mMaxNotEmptyGroupIndex; //Field offset: 0x24

	public ItemPosMgr(float itemDefaultSize) { }

	public bool GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos) { }

	public float GetItemPos(int itemIndex) { }

	public void SetItemMaxCount(int maxCount) { }

	public void SetItemSize(int itemIndex, float size) { }

	public void Update(bool updateAll) { }

}

