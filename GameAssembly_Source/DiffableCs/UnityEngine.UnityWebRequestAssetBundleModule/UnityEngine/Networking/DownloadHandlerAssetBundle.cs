namespace UnityEngine.Networking;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DownloadHandlerAssetBundle : DownloadHandler
{

	public AssetBundle assetBundle
	{
		 get { } //Length: 51
	}

	public DownloadHandlerAssetBundle(string url, uint crc) { }

	public DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc) { }

	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc) { }

	public AssetBundle get_assetBundle() { }

	protected virtual Byte[] GetData() { }

	protected virtual string GetText() { }

	private void InternalCreateAssetBundle(string url, uint crc) { }

	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

}

