namespace UnityEngine.Networking;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DownloadHandler : IDisposable
{
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10

	public Byte[] data
	{
		 get { } //Length: 17
	}

	public string text
	{
		 get { } //Length: 17
	}

	[VisibleToOtherModules]
	internal DownloadHandler() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public Byte[] get_data() { }

	public string get_text() { }

	private string GetContentType() { }

	protected override Byte[] GetData() { }

	protected override string GetText() { }

	private Encoding GetTextEncoder() { }

	[NativeThrows]
	[VisibleToOtherModules]
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	[Obsolete]
	protected override void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	protected override void ReceiveContentLengthHeader(ulong contentLength) { }

	[NativeMethod]
	private void Release() { }

}

