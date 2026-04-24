namespace Assets.Scripts.Graphics;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PostEffectsBase : MonoBehaviour
{
	protected bool supportHDRTextures; //Field offset: 0x18
	protected bool supportDX11; //Field offset: 0x19
	protected bool isSupported; //Field offset: 0x1A
	private List<Material> createdMaterials; //Field offset: 0x20

	public PostEffectsBase() { }

	public override bool CheckResources() { }

	private bool CheckShader(Shader s) { }

	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	protected bool CheckSupport() { }

	protected bool CheckSupport(bool needDepth) { }

	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	protected Material CreateMaterial(Shader s, Material m2Create) { }

	protected void DrawBorder(RenderTexture dest, Material material) { }

	public bool Dx11Support() { }

	protected void NotSupported() { }

	protected override void OnDestroy() { }

	private void OnEnable() { }

	private void RemoveCreatedMaterials() { }

	protected void ReportAutoDisable() { }

	protected override void Start() { }

}

