namespace ZenFulcrum.EmbeddedBrowser;

public class Cookie
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, DateTime> <>9__17_0; //Field offset: 0x8
		public static Func<DateTime, String> <>9__18_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal DateTime <Copy>b__17_0(string s) { }

		internal string <Copy>b__18_0(DateTime s) { }

	}

	private static readonly Regex dateRegex; //Field offset: 0x0
	private CookieManager cookies; //Field offset: 0x10
	private NativeCookie original; //Field offset: 0x18
	public string name; //Field offset: 0x20
	public string value; //Field offset: 0x28
	public string domain; //Field offset: 0x30
	public string path; //Field offset: 0x38
	public DateTime creation; //Field offset: 0x40
	public DateTime lastAccess; //Field offset: 0x48
	public Nullable<DateTime> expires; //Field offset: 0x50
	public bool secure; //Field offset: 0x60
	public bool httpOnly; //Field offset: 0x61

	private static Cookie() { }

	public Cookie(CookieManager cookies) { }

	internal Cookie(CookieManager cookies, NativeCookie cookie) { }

	public static void Copy(NativeCookie src, Cookie dest) { }

	public static void Copy(Cookie src, NativeCookie dest) { }

	public void Delete() { }

	public static void Init() { }

	public void Update() { }

}

