namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[VisibleToOtherModules]
internal sealed class GUIClip
{
	[VisibleToOtherModules]
	public struct ParentClipScope : IDisposable
	{
		private bool m_Disposed; //Field offset: 0x0

		public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect) { }

		public override void Dispose() { }

	}


	internal static Rect visibleRect
	{
		[FreeFunction]
		internal get { } //Length: 60
	}

	[FreeFunction]
	internal static Rect get_visibleRect() { }

	private static void get_visibleRect_Injected(out Rect ret) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal static Matrix4x4 GetMatrix() { }

	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal static int Internal_GetCount() { }

	[VisibleToOtherModules]
	internal static void Internal_Pop() { }

	[VisibleToOtherModules]
	internal static void Internal_PopParentClip() { }

	[VisibleToOtherModules]
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModules]
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

	internal static void Pop() { }

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModules]
	internal static void SetMatrix(Matrix4x4 m) { }

	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

}

