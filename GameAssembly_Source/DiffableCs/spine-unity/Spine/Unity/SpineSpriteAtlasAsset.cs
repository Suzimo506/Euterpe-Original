namespace Spine.Unity;

[CreateAssetMenu]
public class SpineSpriteAtlasAsset : AtlasAssetBase
{
	internal class SavedRegionInfo
	{
		public float x; //Field offset: 0x10
		public float y; //Field offset: 0x14
		public float width; //Field offset: 0x18
		public float height; //Field offset: 0x1C
		public SpritePackingRotation packingRotation; //Field offset: 0x20

		public SavedRegionInfo() { }

	}

	public SpriteAtlas spriteAtlasFile; //Field offset: 0x18
	public Material[] materials; //Field offset: 0x20
	protected Atlas atlas; //Field offset: 0x28
	public bool updateRegionsInPlayMode; //Field offset: 0x30
	[SerializeField]
	protected SavedRegionInfo[] savedRegions; //Field offset: 0x38

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

	public SpineSpriteAtlasAsset() { }

	public static Sprite[] AccessPackedSprites(SpriteAtlas spriteAtlas) { }

	public static Texture2D AccessPackedTexture(Sprite[] sprites) { }

	protected void AssignRegionsFromSavedRegions(Sprite[] sprites, Atlas usedAtlas) { }

	public virtual void Clear() { }

	public static SpineSpriteAtlasAsset CreateRuntimeInstance(SpriteAtlas spriteAtlasFile, Material[] materials, bool initialize) { }

	public virtual bool get_IsLoaded() { }

	public virtual int get_MaterialCount() { }

	public virtual IEnumerable<Material> get_Materials() { }

	public virtual Material get_PrimaryMaterial() { }

	public virtual Atlas GetAtlas() { }

	private Atlas LoadAtlas(SpriteAtlas spriteAtlas) { }

	private void Reset() { }

}

