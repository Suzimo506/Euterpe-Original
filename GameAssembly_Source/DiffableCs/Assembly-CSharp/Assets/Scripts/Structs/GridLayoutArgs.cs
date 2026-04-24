namespace Assets.Scripts.Structs;

public struct GridLayoutArgs
{
	public Vector2 cellSize; //Field offset: 0x0
	public Vector2Int paddingLR; //Field offset: 0x8
	public Vector2Int paddingTB; //Field offset: 0x10
	public Vector2 spacing; //Field offset: 0x18
	public Corner startCorner; //Field offset: 0x20
	public Axis startAxis; //Field offset: 0x24
	public TextAnchor childAlignment; //Field offset: 0x28
	public Constraint constraint; //Field offset: 0x2C
	public int constraintCount; //Field offset: 0x30

	public void SetGridLayout(GridLayoutGroup layout) { }

}

