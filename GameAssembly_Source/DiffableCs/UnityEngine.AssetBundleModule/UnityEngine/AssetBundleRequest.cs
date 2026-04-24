namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class AssetBundleRequest : AsyncOperation
{

	public Object[] allAssets
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public object asset
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public AssetBundleRequest() { }

	[NativeMethod]
	public Object[] get_allAssets() { }

	[NativeMethod]
	public object get_asset() { }

}

