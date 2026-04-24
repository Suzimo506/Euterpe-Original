//Type is in global namespace

public class YlyDelegateUtil
{
	internal sealed class StringDelegate : MulticastDelegate
	{

		public StringDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string arg, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string arg) { }

	}

	internal sealed class VoidDelegate : MulticastDelegate
	{

		public VoidDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject go, PointerEventData eventData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject go, PointerEventData eventData = null) { }

	}


	public YlyDelegateUtil() { }

}

