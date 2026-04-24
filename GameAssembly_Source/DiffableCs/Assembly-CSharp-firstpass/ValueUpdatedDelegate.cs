//Type is in global namespace

public sealed class ValueUpdatedDelegate : MulticastDelegate
{

	public ValueUpdatedDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(float current, float previous, float difference, float adjustedDifference, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(float current, float previous, float difference, float adjustedDifference) { }

}

