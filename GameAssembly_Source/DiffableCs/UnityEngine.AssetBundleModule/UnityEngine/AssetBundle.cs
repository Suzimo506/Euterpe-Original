namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AssetBundle : object
{

	private AssetBundle() { }

	[NativeMethod]
	public String[] GetAllAssetNames() { }

	public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles() { }

	[FreeFunction]
	internal static AssetBundle[] GetAllLoadedAssetBundles_Native() { }

	public Object[] LoadAllAssets(Type type) { }

	public Object[] LoadAllAssets() { }

	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	public AssetBundleRequest LoadAllAssetsAsync() { }

	public AssetBundleRequest LoadAllAssetsAsync() { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object LoadAsset(string name, Type type) { }

	[NativeMethod]
	[NativeThrows]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	[NativeMethod]
	[NativeThrows]
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	public Object[] LoadAssetWithSubAssets(string name, Type type) { }

	[NativeMethod]
	[NativeThrows]
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type) { }

	[NativeMethod]
	[NativeThrows]
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

	public static AssetBundle LoadFromFile(string path, uint crc) { }

	[FreeFunction]
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunction]
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	[NativeMethod]
	public void Unload(bool unloadAllLoadedObjects) { }

}

