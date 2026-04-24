namespace UnityEngine.Networking;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class UploadHandler : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public string contentType
	{
		 set { } //Length: 17
	}

	internal UploadHandler() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod]
	private void InternalSetContentType(string newContentType) { }

	[NativeMethod]
	private void Release() { }

	public void set_contentType(string value) { }

	internal override void SetContentType(string newContentType) { }

}

