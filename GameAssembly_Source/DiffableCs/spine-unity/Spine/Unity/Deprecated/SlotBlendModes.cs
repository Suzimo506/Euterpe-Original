namespace Spine.Unity.Deprecated;

[DisallowMultipleComponent]
[Obsolete]
public class SlotBlendModes : MonoBehaviour
{
	internal struct MaterialTexturePair
	{
		public Texture2D texture2D; //Field offset: 0x0
		public Material material; //Field offset: 0x8

	}

	public class MaterialWithRefcount
	{
		public Material materialClone; //Field offset: 0x10
		public int refcount; //Field offset: 0x18

		public MaterialWithRefcount(Material mat) { }

	}

	public struct SlotMaterialTextureTuple
	{
		public Slot slot; //Field offset: 0x0
		public Texture2D texture2D; //Field offset: 0x8
		public Material material; //Field offset: 0x10

		public SlotMaterialTextureTuple(Slot slot, Material material, Texture2D texture) { }

	}

	private static Dictionary<MaterialTexturePair, MaterialWithRefcount> materialTable; //Field offset: 0x0
	public Material multiplyMaterialSource; //Field offset: 0x18
	public Material screenMaterialSource; //Field offset: 0x20
	private Texture2D texture; //Field offset: 0x28
	private SlotMaterialTextureTuple[] slotsWithCustomMaterial; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Applied>k__BackingField; //Field offset: 0x38

	public private bool Applied
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal static Dictionary<MaterialTexturePair, MaterialWithRefcount> MaterialTable
	{
		internal get { } //Length: 138
	}

	public SlotBlendModes() { }

	public void Apply() { }

	[CompilerGenerated]
	public bool get_Applied() { }

	internal static Dictionary<MaterialTexturePair, MaterialWithRefcount> get_MaterialTable() { }

	internal static MaterialWithRefcount GetExistingMaterialFor(Material materialSource, Texture2D texture) { }

	internal static Material GetOrAddMaterialFor(Material materialSource, Texture2D texture) { }

	public void GetTexture() { }

	private void OnDestroy() { }

	public void Remove() { }

	internal static void RemoveMaterialFromTable(Material materialSource, Texture2D texture) { }

	[CompilerGenerated]
	private void set_Applied(bool value) { }

	private void Start() { }

}

