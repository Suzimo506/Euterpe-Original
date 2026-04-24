namespace Assets.Scripts.Graphics;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteInEditMode]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GradientFog : PostEffectsBase
{
	public Gradient fogGradient; //Field offset: 0x28
	public Shader fogShader; //Field offset: 0x30
	private Material m_FogMaterial; //Field offset: 0x38
	private RenderTexture m_RenderTexture; //Field offset: 0x40

	public GradientFog() { }

	public virtual bool CheckResources() { }

	private void OnPostRender() { }

	private void OnPreRender() { }

}

