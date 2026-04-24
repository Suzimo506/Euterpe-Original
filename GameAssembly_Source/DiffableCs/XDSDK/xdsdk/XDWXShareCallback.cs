namespace xdsdk;

internal class XDWXShareCallback : AndroidJavaProxy
{
	private XDCallback callback; //Field offset: 0x20

	public XDWXShareCallback(XDCallback callback) { }

	public virtual AndroidJavaObject Invoke(string methodName, Object[] javaArgs) { }

}

