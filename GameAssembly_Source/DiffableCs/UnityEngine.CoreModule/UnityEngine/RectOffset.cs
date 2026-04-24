namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class RectOffset
{
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10
	private readonly object m_SourceStyle; //Field offset: 0x18

	[NativeProperty]
	public int bottom
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int horizontal
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public int left
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public int right
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public int top
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int vertical
	{
		 get { } //Length: 51
	}

	public RectOffset() { }

	[VisibleToOtherModules]
	internal RectOffset(object sourceStyle, IntPtr source) { }

	public RectOffset(int left, int right, int top, int bottom) { }

	private void Destroy() { }

	protected virtual void Finalize() { }

	public int get_bottom() { }

	public int get_horizontal() { }

	public int get_left() { }

	public int get_right() { }

	public int get_top() { }

	public int get_vertical() { }

	[ThreadAndSerializationSafe]
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafe]
	private static void InternalDestroy(IntPtr ptr) { }

	public Rect Remove(Rect rect) { }

	private void Remove_Injected(ref Rect rect, out Rect ret) { }

	public void set_bottom(int value) { }

	public void set_left(int value) { }

	public void set_right(int value) { }

	public void set_top(int value) { }

	public virtual string ToString() { }

}

