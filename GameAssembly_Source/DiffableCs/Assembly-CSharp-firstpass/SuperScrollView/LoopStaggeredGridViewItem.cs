namespace SuperScrollView;

public class LoopStaggeredGridViewItem : MonoBehaviour
{
	private int mItemIndex; //Field offset: 0x18
	private int mItemIndexInGroup; //Field offset: 0x1C
	private int mItemId; //Field offset: 0x20
	private float mPadding; //Field offset: 0x24
	private float mExtraPadding; //Field offset: 0x28
	private bool mIsInitHandlerCalled; //Field offset: 0x2C
	private string mItemPrefabName; //Field offset: 0x30
	private RectTransform mCachedRectTransform; //Field offset: 0x38
	private LoopStaggeredGridView mParentListView; //Field offset: 0x40
	private float mDistanceWithViewPortSnapCenter; //Field offset: 0x48
	private int mItemCreatedCheckFrameCount; //Field offset: 0x4C
	private float mStartPosOffset; //Field offset: 0x50
	private object mUserObjectData; //Field offset: 0x58
	private int mUserIntData1; //Field offset: 0x60
	private int mUserIntData2; //Field offset: 0x64
	private string mUserStringData1; //Field offset: 0x68
	private string mUserStringData2; //Field offset: 0x70

	public float BottomY
	{
		 get { } //Length: 202
	}

	public RectTransform CachedRectTransform
	{
		 get { } //Length: 167
	}

	public float DistanceWithViewPortSnapCenter
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ExtraPadding
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool IsInitHandlerCalled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int ItemCreatedCheckFrameCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int ItemId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int ItemIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int ItemIndexInGroup
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string ItemPrefabName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float ItemSize
	{
		 get { } //Length: 127
	}

	public float ItemSizeWithPadding
	{
		 get { } //Length: 144
	}

	public float LeftX
	{
		 get { } //Length: 207
	}

	public float Padding
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public LoopStaggeredGridView ParentListView
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float RightX
	{
		 get { } //Length: 204
	}

	public float StartPosOffset
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float TopY
	{
		 get { } //Length: 195
	}

	public int UserIntData1
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int UserIntData2
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public object UserObjectData
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string UserStringData1
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string UserStringData2
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public LoopStaggeredGridViewItem() { }

	public float get_BottomY() { }

	public RectTransform get_CachedRectTransform() { }

	public float get_DistanceWithViewPortSnapCenter() { }

	public float get_ExtraPadding() { }

	public bool get_IsInitHandlerCalled() { }

	public int get_ItemCreatedCheckFrameCount() { }

	public int get_ItemId() { }

	public int get_ItemIndex() { }

	public int get_ItemIndexInGroup() { }

	public string get_ItemPrefabName() { }

	public float get_ItemSize() { }

	public float get_ItemSizeWithPadding() { }

	public float get_LeftX() { }

	public float get_Padding() { }

	public LoopStaggeredGridView get_ParentListView() { }

	public float get_RightX() { }

	public float get_StartPosOffset() { }

	public float get_TopY() { }

	public int get_UserIntData1() { }

	public int get_UserIntData2() { }

	public object get_UserObjectData() { }

	public string get_UserStringData1() { }

	public string get_UserStringData2() { }

	public void set_DistanceWithViewPortSnapCenter(float value) { }

	public void set_ExtraPadding(float value) { }

	public void set_IsInitHandlerCalled(bool value) { }

	public void set_ItemCreatedCheckFrameCount(int value) { }

	public void set_ItemId(int value) { }

	public void set_ItemIndex(int value) { }

	public void set_ItemIndexInGroup(int value) { }

	public void set_ItemPrefabName(string value) { }

	public void set_Padding(float value) { }

	public void set_ParentListView(LoopStaggeredGridView value) { }

	public void set_StartPosOffset(float value) { }

	public void set_UserIntData1(int value) { }

	public void set_UserIntData2(int value) { }

	public void set_UserObjectData(object value) { }

	public void set_UserStringData1(string value) { }

	public void set_UserStringData2(string value) { }

}

