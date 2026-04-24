namespace SuperScrollView;

public class ItemSizeGroup
{
	public Single[] mItemSizeArray; //Field offset: 0x10
	public Single[] mItemStartPosArray; //Field offset: 0x18
	public int mItemCount; //Field offset: 0x20
	private int mDirtyBeginIndex; //Field offset: 0x24
	public float mGroupSize; //Field offset: 0x28
	public float mGroupStartPos; //Field offset: 0x2C
	public float mGroupEndPos; //Field offset: 0x30
	public int mGroupIndex; //Field offset: 0x34
	private float mItemDefaultSize; //Field offset: 0x38
	private int mMaxNoZeroIndex; //Field offset: 0x3C

	public bool IsDirty
	{
		 get { } //Length: 10
	}

	public ItemSizeGroup(int index, float itemDefaultSize) { }

	public void ClearOldData() { }

	public bool get_IsDirty() { }

	public int GetItemIndexByPos(float pos) { }

	public float GetItemStartPos(int index) { }

	public void Init() { }

	public void RecalcGroupSize() { }

	public void SetItemCount(int count) { }

	public float SetItemSize(int index, float size) { }

	public void UpdateAllItemStartPos() { }

}

