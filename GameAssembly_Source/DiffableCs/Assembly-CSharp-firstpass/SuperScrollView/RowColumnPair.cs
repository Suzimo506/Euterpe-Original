namespace SuperScrollView;

public struct RowColumnPair
{
	public int mRow; //Field offset: 0x0
	public int mColumn; //Field offset: 0x4

	public RowColumnPair(int row1, int column1) { }

	public bool Equals(RowColumnPair other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RowColumnPair a, RowColumnPair b) { }

	public static bool op_Inequality(RowColumnPair a, RowColumnPair b) { }

}

