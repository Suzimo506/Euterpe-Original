namespace System.Net;

public class HttpListenerBasicIdentity : GenericIdentity
{
	private string password; //Field offset: 0x88

	public HttpListenerBasicIdentity(string username, string password) { }

}

