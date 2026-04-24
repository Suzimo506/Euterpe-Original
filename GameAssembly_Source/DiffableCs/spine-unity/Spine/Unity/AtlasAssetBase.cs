namespace Spine.Unity;

public abstract class AtlasAssetBase : ScriptableObject
{

	public abstract bool IsLoaded
	{
		 get { } //Length: 0
	}

	public abstract int MaterialCount
	{
		 get { } //Length: 0
	}

	public abstract IEnumerable<Material> Materials
	{
		 get { } //Length: 0
	}

	public abstract Material PrimaryMaterial
	{
		 get { } //Length: 0
	}

	protected AtlasAssetBase() { }

	public abstract void Clear() { }

	public abstract bool get_IsLoaded() { }

	public abstract int get_MaterialCount() { }

	public abstract IEnumerable<Material> get_Materials() { }

	public abstract Material get_PrimaryMaterial() { }

	public abstract Atlas GetAtlas() { }

}

