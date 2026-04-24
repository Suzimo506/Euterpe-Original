namespace SuperScrollView;

public class LoopListViewItem2 : MonoBehaviour
{
	private int mItemIndex; //Field offset: 0x18
	private int mItemId; //Field offset: 0x1C
	private BaseLoopListView2 mParentListView; //Field offset: 0x20
	private bool mIsInitHandlerCalled; //Field offset: 0x28
	private string mItemPrefabName; //Field offset: 0x30
	private RectTransform mCachedRectTransform; //Field offset: 0x38
	private Vector2 mPadding; //Field offset: 0x40
	private float mDistanceWithViewPortSnapCenter; //Field offset: 0x48
	private int mItemCreatedCheckFrameCount; //Field offset: 0x4C
	private float mStartPosOffset; //Field offset: 0x50
	private int m_TreeItemIndex; //Field offset: 0x54

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

	public float ItemSize
	{
		 get { } //Length: 127
	}

	public float ItemSizeWithPadding
	{
		 get { } //Length: 183
	}

	public float LeftX
	{
		 get { } //Length: 207
	}

	public Vector2 Padding
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public BaseLoopListView2 ParentListView
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

	public int treeItemIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public LoopListViewItem2() { }

	public float get_BottomY() { }

	public RectTransform get_CachedRectTransform() { }

	public float get_DistanceWithViewPortSnapCenter() { }

	public bool get_IsInitHandlerCalled() { }

	public int get_ItemCreatedCheckFrameCount() { }

	public int get_ItemId() { }

	public int get_ItemIndex() { }

	public string get_ItemPrefabName() { }

	public float get_ItemSize() { }

	public float get_ItemSizeWithPadding() { }

	public float get_LeftX() { }

	public Vector2 get_Padding() { }

	public BaseLoopListView2 get_ParentListView() { }

	public float get_RightX() { }

	public float get_StartPosOffset() { }

	public float get_TopY() { }

	public int get_treeItemIndex() { }

	public void set_DistanceWithViewPortSnapCenter(float value) { }

	public void set_IsInitHandlerCalled(bool value) { }

	public void set_ItemCreatedCheckFrameCount(int value) { }

	public void set_ItemId(int value) { }

	public void set_ItemIndex(int value) { }

	public void set_ItemPrefabName(string value) { }

	public void set_Padding(Vector2 value) { }

	public void set_ParentListView(BaseLoopListView2 value) { }

	public void set_StartPosOffset(float value) { }

	public void set_treeItemIndex(int value) { }

}

