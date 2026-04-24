namespace SuperScrollView;

public class LoopGridViewItem : MonoBehaviour
{
	private int mItemIndex; //Field offset: 0x18
	private int mRow; //Field offset: 0x1C
	private int mColumn; //Field offset: 0x20
	private int mItemId; //Field offset: 0x24
	private LoopGridView mParentGridView; //Field offset: 0x28
	private bool mIsInitHandlerCalled; //Field offset: 0x30
	private string mItemPrefabName; //Field offset: 0x38
	private RectTransform mCachedRectTransform; //Field offset: 0x40
	private int mItemCreatedCheckFrameCount; //Field offset: 0x48
	private object mUserObjectData; //Field offset: 0x50
	private int mUserIntData1; //Field offset: 0x58
	private int mUserIntData2; //Field offset: 0x5C
	private string mUserStringData1; //Field offset: 0x60
	private string mUserStringData2; //Field offset: 0x68
	private LoopGridViewItem mPrevItem; //Field offset: 0x70
	private LoopGridViewItem mNextItem; //Field offset: 0x78

	public RectTransform CachedRectTransform
	{
		 get { } //Length: 167
	}

	public int Column
	{
		 get { } //Length: 4
		 set { } //Length: 4
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

	public string ItemPrefabName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public LoopGridViewItem NextItem
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public LoopGridView ParentGridView
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public LoopGridViewItem PrevItem
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int Row
	{
		 get { } //Length: 4
		 set { } //Length: 4
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

	public LoopGridViewItem() { }

	public RectTransform get_CachedRectTransform() { }

	public int get_Column() { }

	public bool get_IsInitHandlerCalled() { }

	public int get_ItemCreatedCheckFrameCount() { }

	public int get_ItemId() { }

	public int get_ItemIndex() { }

	public string get_ItemPrefabName() { }

	public LoopGridViewItem get_NextItem() { }

	public LoopGridView get_ParentGridView() { }

	public LoopGridViewItem get_PrevItem() { }

	public int get_Row() { }

	public int get_UserIntData1() { }

	public int get_UserIntData2() { }

	public object get_UserObjectData() { }

	public string get_UserStringData1() { }

	public string get_UserStringData2() { }

	public void set_Column(int value) { }

	public void set_IsInitHandlerCalled(bool value) { }

	public void set_ItemCreatedCheckFrameCount(int value) { }

	public void set_ItemId(int value) { }

	public void set_ItemIndex(int value) { }

	public void set_ItemPrefabName(string value) { }

	public void set_NextItem(LoopGridViewItem value) { }

	public void set_ParentGridView(LoopGridView value) { }

	public void set_PrevItem(LoopGridViewItem value) { }

	public void set_Row(int value) { }

	public void set_UserIntData1(int value) { }

	public void set_UserIntData2(int value) { }

	public void set_UserObjectData(object value) { }

	public void set_UserStringData1(string value) { }

	public void set_UserStringData2(string value) { }

}

