//Type is in global namespace

public class PeroScrollRect : ScrollRect
{
	internal enum ScrollDirection
	{
		None = 0,
		Vertical = 1,
		Horizontal = 2,
	}

	public ScrollDirection scrollDirection; //Field offset: 0x128
	public float mouseWheelScale; //Field offset: 0x12C

	public PeroScrollRect() { }

	private void EnsureLayoutHasRebuilt() { }

	public virtual void OnScroll(PointerEventData data) { }

}

