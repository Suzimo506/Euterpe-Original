namespace ZenFulcrum.EmbeddedBrowser;

public class CookieManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Promise<List`1<Cookie>> promise; //Field offset: 0x10
		public List<Cookie> result; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <CB_GetCookieFunc>b__0() { }

	}

	private class CookieFetch
	{
		public GetCookieFunc nativeCB; //Field offset: 0x10
		public Promise<List`1<Cookie>> promise; //Field offset: 0x18
		public CookieManager manager; //Field offset: 0x20
		public List<Cookie> result; //Field offset: 0x28

		public CookieFetch() { }

	}

	private static CookieFetch currentFetch; //Field offset: 0x0
	internal readonly Browser browser; //Field offset: 0x10

	public CookieManager(Browser browser) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_GetCookieFunc(NativeCookie cookie) { }

	public void ClearAll() { }

	public IPromise<List`1<Cookie>> GetCookies() { }

}

