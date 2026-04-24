namespace Spine.Unity;

[CreateAssetMenu]
public class SpineAtlasAsset : AtlasAssetBase
{
	public TextAsset atlasFile; //Field offset: 0x18
	public Material[] materials; //Field offset: 0x20
	protected Atlas atlas; //Field offset: 0x28

	public virtual bool IsLoaded
	{
		 get { } //Length: 9
	}

	public virtual int MaterialCount
	{
		 get { } //Length: 14
	}

	public virtual IEnumerable<Material> Materials
	{
		 get { } //Length: 5
	}

	public virtual Material PrimaryMaterial
	{
		 get { } //Length: 49
	}

	public SpineAtlasAsset() { }

	public virtual void Clear() { }

	public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Material[] materials, bool initialize) { }

	public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Material materialPropertySource, bool initialize) { }

	public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Shader shader, bool initialize) { }

	public Mesh GenerateMesh(string name, Mesh mesh, out Material material, float scale = 0.01) { }

	public virtual bool get_IsLoaded() { }

	public virtual int get_MaterialCount() { }

	public virtual IEnumerable<Material> get_Materials() { }

	public virtual Material get_PrimaryMaterial() { }

	public virtual Atlas GetAtlas() { }

	private void Reset() { }

}

