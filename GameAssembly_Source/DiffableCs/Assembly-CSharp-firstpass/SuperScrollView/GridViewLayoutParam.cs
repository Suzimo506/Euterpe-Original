namespace SuperScrollView;

public class GridViewLayoutParam
{
	public int mColumnOrRowCount; //Field offset: 0x10
	public float mItemWidthOrHeight; //Field offset: 0x14
	public float mPadding1; //Field offset: 0x18
	public float mPadding2; //Field offset: 0x1C
	public Single[] mCustomColumnOrRowOffsetArray; //Field offset: 0x20

	public GridViewLayoutParam() { }

	public bool CheckParam() { }

}

