namespace Mono.Net;

internal class CFProxy
{
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; //Field offset: 0x0
	private static IntPtr kCFProxyAutoConfigurationURLKey; //Field offset: 0x8
	private static IntPtr kCFProxyHostNameKey; //Field offset: 0x10
	private static IntPtr kCFProxyPasswordKey; //Field offset: 0x18
	private static IntPtr kCFProxyPortNumberKey; //Field offset: 0x20
	private static IntPtr kCFProxyTypeKey; //Field offset: 0x28
	private static IntPtr kCFProxyUsernameKey; //Field offset: 0x30
	private static IntPtr kCFProxyTypeAutoConfigurationURL; //Field offset: 0x38
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; //Field offset: 0x40
	private static IntPtr kCFProxyTypeFTP; //Field offset: 0x48
	private static IntPtr kCFProxyTypeHTTP; //Field offset: 0x50
	private static IntPtr kCFProxyTypeHTTPS; //Field offset: 0x58
	private static IntPtr kCFProxyTypeSOCKS; //Field offset: 0x60
	private CFDictionary settings; //Field offset: 0x10

	public IntPtr AutoConfigurationJavaScript
	{
		 get { } //Length: 188
	}

	public IntPtr AutoConfigurationUrl
	{
		 get { } //Length: 190
	}

	public string HostName
	{
		 get { } //Length: 200
	}

	public string Password
	{
		 get { } //Length: 200
	}

	public int Port
	{
		 get { } //Length: 403
	}

	public CFProxyType ProxyType
	{
		 get { } //Length: 200
	}

	public string Username
	{
		 get { } //Length: 200
	}

	private static CFProxy() { }

	internal CFProxy(CFDictionary settings) { }

	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	public IntPtr get_AutoConfigurationJavaScript() { }

	public IntPtr get_AutoConfigurationUrl() { }

	public string get_HostName() { }

	public string get_Password() { }

	public int get_Port() { }

	public CFProxyType get_ProxyType() { }

	public string get_Username() { }

}

