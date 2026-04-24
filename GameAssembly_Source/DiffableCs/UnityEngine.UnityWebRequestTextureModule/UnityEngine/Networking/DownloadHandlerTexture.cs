namespace UnityEngine.Networking;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DownloadHandlerTexture : DownloadHandler
{
	private Texture2D mTexture; //Field offset: 0x18
	private bool mHasTexture; //Field offset: 0x20
	private bool mNonReadable; //Field offset: 0x21

	public Texture2D texture
	{
		 get { } //Length: 319
	}

	public DownloadHandlerTexture() { }

	public DownloadHandlerTexture(bool readable) { }

	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	public Texture2D get_texture() { }

	protected virtual Byte[] GetData() { }

	private void InternalCreateTexture(bool readable) { }

	private Texture2D InternalGetTexture() { }

	[NativeThrows]
	private Texture2D InternalGetTextureNative() { }

}

