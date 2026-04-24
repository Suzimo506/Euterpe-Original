namespace xdsdk;

internal class XDSDKExitCallback : AndroidJavaProxy
{
	private XDCallback callback; //Field offset: 0x20

	public XDSDKExitCallback(XDCallback callback) { }

	public virtual AndroidJavaObject Invoke(string methodName, Object[] javaArgs) { }

}

