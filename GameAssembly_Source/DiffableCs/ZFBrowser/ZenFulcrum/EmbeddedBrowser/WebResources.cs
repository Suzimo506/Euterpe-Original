namespace ZenFulcrum.EmbeddedBrowser;

public abstract class WebResources
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public FileInfo file; //Field offset: 0x10
		public WebResources <>4__this; //Field offset: 0x18
		public int id; //Field offset: 0x20
		public bool forceDownload; //Field offset: 0x24

		public <>c__DisplayClass7_0() { }

		internal void <SendFile>b__0() { }

	}

	internal class ResponsePreamble
	{
		public int statusCode; //Field offset: 0x10
		public string statusText; //Field offset: 0x18
		public string mimeType; //Field offset: 0x20
		public int length; //Field offset: 0x28
		public Dictionary<String, String> headers; //Field offset: 0x30

		public ResponsePreamble() { }

	}

	public static readonly Dictionary<String, String> extensionMimeTypes; //Field offset: 0x0
	public static readonly Dictionary<Int32, String> statusTexts; //Field offset: 0x8

	private static WebResources() { }

	protected WebResources() { }

	public abstract void HandleRequest(int id, string url) { }

	protected void SendData(int id, Byte[] data, int length = -1) { }

	protected void SendEnd(int id) { }

	protected override void SendError(int id, string html, int errorCode = 500) { }

	protected override void SendFile(int id, FileInfo file, bool forceDownload = false) { }

	protected void SendPreamble(int id, ResponsePreamble pre) { }

	protected override void SendResponse(int id, Byte[] data, string mimeType = "application/octet-stream") { }

	protected override void SendResponse(int id, string text, string mimeType = "text/html; charset=UTF-8") { }

}

