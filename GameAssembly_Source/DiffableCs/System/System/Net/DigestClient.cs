namespace System.Net;

internal class DigestClient : IAuthenticationModule
{
	private static readonly Hashtable cache; //Field offset: 0x6A976

	public override string AuthenticationType
	{
		 get { } //Length: 43
	}

	private static Hashtable Cache
	{
		private get { } //Length: 365
	}

	private static DigestClient() { }

	public DigestClient() { }

	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	private static void CheckExpired(int count) { }

	public override string get_AuthenticationType() { }

	private static Hashtable get_Cache() { }

	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

