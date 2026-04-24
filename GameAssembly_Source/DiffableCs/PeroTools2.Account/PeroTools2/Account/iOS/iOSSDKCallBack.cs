namespace PeroTools2.Account.iOS;

public class iOSSDKCallBack
{
	internal sealed class Callback : MulticastDelegate
	{

		public Callback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int code, string res, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int code, string res) { }

	}

	private static IiOSSDKCallback s_Callback; //Field offset: 0x6AD0A

	public iOSSDKCallBack() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void OnCallback(int code, string result) { }

	public static void RegisterCallback(IiOSSDKCallback callback) { }

}

