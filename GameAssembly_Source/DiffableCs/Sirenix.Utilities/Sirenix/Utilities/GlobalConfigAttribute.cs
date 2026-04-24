namespace Sirenix.Utilities;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GlobalConfigAttribute : Attribute
{
	private string assetPath; //Field offset: 0x10
	[CompilerGenerated]
	private bool <UseAsset>k__BackingField; //Field offset: 0x18

	public string AssetPath
	{
		 get { } //Length: 349
	}

	internal string AssetPathWithAssetsPrefix
	{
		internal get { } //Length: 113
	}

	internal string AssetPathWithoutAssetsPrefix
	{
		internal get { } //Length: 121
	}

	[Obsolete]
	public string FullPath
	{
		 get { } //Length: 91
	}

	public bool IsInResourcesFolder
	{
		 get { } //Length: 89
	}

	public string ResourcesPath
	{
		 get { } //Length: 199
	}

	[Obsolete]
	public bool UseAsset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GlobalConfigAttribute() { }

	public GlobalConfigAttribute(string assetPath) { }

	public string get_AssetPath() { }

	internal string get_AssetPathWithAssetsPrefix() { }

	internal string get_AssetPathWithoutAssetsPrefix() { }

	public string get_FullPath() { }

	public bool get_IsInResourcesFolder() { }

	public string get_ResourcesPath() { }

	[CompilerGenerated]
	public bool get_UseAsset() { }

	[CompilerGenerated]
	public void set_UseAsset(bool value) { }

}

