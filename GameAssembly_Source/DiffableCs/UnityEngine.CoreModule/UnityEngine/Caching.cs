namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Caching
{

	public static bool compressionEnabled
	{
		 set { } //Length: 51
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Cache currentCacheForWriting
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 59
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[NativeThrows]
		 set { } //Length: 51
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Cache defaultCache
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 59
	}

	public static bool ready
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	public static Cache AddCache(string cachePath) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static Cache AddCache(string cachePath, bool isReadonly) { }

	private static void AddCache_Injected(string cachePath, bool isReadonly, out Cache ret) { }

	public static bool ClearAllCachedVersions(string assetBundleName) { }

	public static bool ClearCachedVersion(string assetBundleName, Hash128 hash) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash) { }

	private static bool ClearCachedVersionInternal_Injected(string assetBundleName, ref Hash128 hash) { }

	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	private static bool ClearCachedVersions_Injected(string assetBundleName, ref Hash128 hash, bool keepInputVersion) { }

	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Cache get_currentCacheForWriting() { }

	private static void get_currentCacheForWriting_Injected(out Cache ret) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Cache get_defaultCache() { }

	private static void get_defaultCache_Injected(out Cache ret) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static bool get_ready() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeThrows]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Cache GetCacheByPath(string cachePath) { }

	private static void GetCacheByPath_Injected(string cachePath, out Cache ret) { }

	public static bool IsVersionCached(CachedAssetBundle cachedBundle) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash) { }

	private static bool IsVersionCached_Injected(string url, string assetBundleName, ref Hash128 hash) { }

	public static void set_compressionEnabled(bool value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeThrows]
	public static void set_currentCacheForWriting(Cache value) { }

	private static void set_currentCacheForWriting_Injected(ref Cache value) { }

}

