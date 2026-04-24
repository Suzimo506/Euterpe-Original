namespace UnityEngine.Yoga;

internal sealed class MeasureFunction : MulticastDelegate
{

	public MeasureFunction(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	public override YogaSize EndInvoke(IAsyncResult result) { }

	public override YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

}

