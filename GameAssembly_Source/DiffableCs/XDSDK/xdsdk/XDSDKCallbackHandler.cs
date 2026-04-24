namespace xdsdk;

internal class XDSDKCallbackHandler : AndroidJavaProxy
{
	private XDCallback callback; //Field offset: 0x20

	public XDSDKCallbackHandler(XDCallback callback) { }

	public virtual AndroidJavaObject Invoke(string methodName, Object[] javaArgs) { }

}

