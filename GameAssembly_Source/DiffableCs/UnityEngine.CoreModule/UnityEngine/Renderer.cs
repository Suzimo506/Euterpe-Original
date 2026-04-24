namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class Renderer : Component
{

	public Bounds bounds
	{
		[FreeFunction]
		 get { } //Length: 81
	}

	public bool enabled
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public LightProbeUsage lightProbeUsage
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Material material
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Material[] materials
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MotionVectorGenerationMode motionVectorGenerationMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Transform probeAnchor
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool receiveShadows
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public ShadowCastingMode shadowCastingMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Material sharedMaterial
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Material[] sharedMaterials
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string sortingLayerName
	{
		 set { } //Length: 66
	}

	public int sortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Renderer() { }

	[FreeFunction]
	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	public LightProbeUsage get_lightProbeUsage() { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	public Transform get_probeAnchor() { }

	public bool get_receiveShadows() { }

	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	public ShadowCastingMode get_shadowCastingMode() { }

	public Material get_sharedMaterial() { }

	public Material[] get_sharedMaterials() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	[FreeFunction]
	private Material GetMaterial() { }

	[FreeFunction]
	private Material[] GetMaterialArray() { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunction]
	private Material GetSharedMaterial() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Material[] GetSharedMaterialArray() { }

	[FreeFunction]
	public bool HasPropertyBlock() { }

	[FreeFunction]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunction]
	internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) { }

	[FreeFunction]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction]
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	public void set_enabled(bool value) { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	public void set_material(Material value) { }

	public void set_materials(Material[] value) { }

	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	public void set_probeAnchor(Transform value) { }

	public void set_receiveShadows(bool value) { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	[FreeFunction]
	private void SetMaterial(Material m) { }

	[FreeFunction]
	private void SetMaterialArray(Material[] m) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

