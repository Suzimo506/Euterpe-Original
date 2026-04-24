namespace SuperScrollView;

public abstract class BaseLoopListView2 : MonoBehaviour
{
	internal class SnapData
	{
		public SnapStatus mSnapStatus; //Field offset: 0x10
		public int mSnapTargetIndex; //Field offset: 0x14
		public float mTargetSnapVal; //Field offset: 0x18
		public float mCurSnapVal; //Field offset: 0x1C
		public bool mIsForceSnapTo; //Field offset: 0x20
		public bool mIsTempTarget; //Field offset: 0x21
		public int mTempTargetIndex; //Field offset: 0x24
		public float mMoveMaxAbsVec; //Field offset: 0x28

		public SnapData() { }

		public void Clear() { }

	}

	[SerializeField]
	protected List<ItemPrefabConfData> mItemPrefabDataList; //Field offset: 0x18
	[SerializeField]
	protected ListItemArrangeType mArrangeType; //Field offset: 0x20
	protected RectTransform mContainerTrans; //Field offset: 0x28
	protected ScrollRect mScrollRect; //Field offset: 0x30
	protected RectTransform mScrollRectTransform; //Field offset: 0x38
	protected RectTransform mViewPortRectTransform; //Field offset: 0x40
	protected int mItemTotalCount; //Field offset: 0x48
	protected bool mIsVertList; //Field offset: 0x4C
	protected Vector3[] mItemWorldCornersBuffer; //Field offset: 0x50
	protected Vector3[] mViewPortRectLocalCorners; //Field offset: 0x58
	protected int mCurReadyMinItemIndex; //Field offset: 0x60
	protected int mCurReadyMaxItemIndex; //Field offset: 0x64
	protected bool mNeedCheckNextMinItem; //Field offset: 0x68
	protected bool mNeedCheckNextMaxItem; //Field offset: 0x69
	protected ItemPosMgr mItemPosMgr; //Field offset: 0x70
	protected LoopListViewInitParam m_InitParam; //Field offset: 0x78
	[SerializeField]
	protected bool mSupportScrollBar; //Field offset: 0x80
	protected bool mIsDraging; //Field offset: 0x81
	protected PointerEventData mPointerEventData; //Field offset: 0x88
	public Action mOnBeginDragAction; //Field offset: 0x90
	public Action mOnDragingAction; //Field offset: 0x98
	public Action mOnEndDragAction; //Field offset: 0xA0
	protected int mLastItemIndex; //Field offset: 0xA8
	protected float mLastItemPadding; //Field offset: 0xAC
	protected float mSmoothDumpVel; //Field offset: 0xB0
	protected float mSnapMoveDefaultMaxAbsVec; //Field offset: 0xB4
	[SerializeField]
	protected bool mItemSnapEnable; //Field offset: 0xB8
	protected Vector3 mLastFrameContainerPos; //Field offset: 0xBC
	protected int mCurSnapNearestItemIndex; //Field offset: 0xC8
	protected Vector2 mAdjustedVec; //Field offset: 0xCC
	protected bool mNeedAdjustVec; //Field offset: 0xD4
	protected int mLeftSnapUpdateExtraCount; //Field offset: 0xD8
	[SerializeField]
	protected Vector2 mViewPortSnapPivot; //Field offset: 0xDC
	[SerializeField]
	protected Vector2 mItemSnapPivot; //Field offset: 0xE4
	protected ClickEventListener mScrollBarClickEventListener; //Field offset: 0xF0
	protected SnapData mCurSnapData; //Field offset: 0xF8
	protected Vector3 mLastSnapCheckPos; //Field offset: 0x100
	protected bool mListViewInited; //Field offset: 0x10C
	protected int mListUpdateCheckFrameCount; //Field offset: 0x110

	public ListItemArrangeType ArrangeType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public RectTransform ContainerTrans
	{
		 get { } //Length: 5
	}

	public bool IsDraging
	{
		 get { } //Length: 8
	}

	public bool IsVertList
	{
		 get { } //Length: 5
	}

	public List<ItemPrefabConfData> ItemPrefabDataList
	{
		 get { } //Length: 5
	}

	public bool ItemSnapEnable
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int ItemTotalCount
	{
		 get { } //Length: 4
	}

	public ScrollRect ScrollRect
	{
		 get { } //Length: 5
	}

	public float SnapMoveDefaultMaxAbsVec
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public bool SupportScrollBar
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	protected BaseLoopListView2() { }

	public ListItemArrangeType get_ArrangeType() { }

	public RectTransform get_ContainerTrans() { }

	public bool get_IsDraging() { }

	public bool get_IsVertList() { }

	public List<ItemPrefabConfData> get_ItemPrefabDataList() { }

	public bool get_ItemSnapEnable() { }

	public int get_ItemTotalCount() { }

	public ScrollRect get_ScrollRect() { }

	public float get_SnapMoveDefaultMaxAbsVec() { }

	public bool get_SupportScrollBar() { }

	public ItemPrefabConfData GetItemPrefabConfData(string prefabName) { }

	public void set_ArrangeType(ListItemArrangeType value) { }

	public void set_ItemSnapEnable(bool value) { }

	public void set_SnapMoveDefaultMaxAbsVec(float value) { }

	public void set_SupportScrollBar(bool value) { }

}

