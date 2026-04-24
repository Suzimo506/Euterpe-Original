namespace Spine.Unity;

[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonRendererCustomMaterials : MonoBehaviour
{
	internal struct AtlasMaterialOverride : IEquatable<AtlasMaterialOverride>
	{
		public bool overrideDisabled; //Field offset: 0x0
		public Material originalMaterial; //Field offset: 0x8
		public Material replacementMaterial; //Field offset: 0x10

		public override bool Equals(AtlasMaterialOverride other) { }

	}

	internal struct SlotMaterialOverride : IEquatable<SlotMaterialOverride>
	{
		public bool overrideDisabled; //Field offset: 0x0
		[SpineSlot(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string slotName; //Field offset: 0x8
		public Material material; //Field offset: 0x10

		public override bool Equals(SlotMaterialOverride other) { }

	}

	public SkeletonRenderer skeletonRenderer; //Field offset: 0x18
	[SerializeField]
	protected List<SlotMaterialOverride> customSlotMaterials; //Field offset: 0x20
	[SerializeField]
	protected List<AtlasMaterialOverride> customMaterialOverrides; //Field offset: 0x28

	public SkeletonRendererCustomMaterials() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RemoveCustomMaterialOverrides() { }

	private void RemoveCustomSlotMaterials() { }

	private void SetCustomMaterialOverrides() { }

	public void SetCustomMats(bool enable) { }

	private void SetCustomSlotMaterials() { }

}

