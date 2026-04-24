namespace UnityEngine;

internal class ScrollViewState
{
	public Rect position; //Field offset: 0x10
	public Rect visibleRect; //Field offset: 0x20
	public Rect viewRect; //Field offset: 0x30
	public Vector2 scrollPosition; //Field offset: 0x40
	public bool apply; //Field offset: 0x48

	[RequiredByNativeCode]
	public ScrollViewState() { }

}

