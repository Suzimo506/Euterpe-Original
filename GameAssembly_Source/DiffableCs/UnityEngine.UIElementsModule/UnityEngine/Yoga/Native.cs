namespace UnityEngine.Yoga;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class Native
{

	[RequiredByNativeCode]
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunction]
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

	[FreeFunction]
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunction]
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunction]
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[RequiredByNativeCode]
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

}

