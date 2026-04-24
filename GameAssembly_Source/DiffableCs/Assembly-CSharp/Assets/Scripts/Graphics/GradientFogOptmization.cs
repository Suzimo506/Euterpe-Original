namespace Assets.Scripts.Graphics;

public class GradientFogOptmization : PostEffectsBase
{
	public Shader fogShader; //Field offset: 0x28
	public Texture fogTexture; //Field offset: 0x30
	private Camera m_Cam; //Field offset: 0x38
	private Material m_FogMaterial; //Field offset: 0x40
	private int m_FogTexId; //Field offset: 0x48
	private int m_Height; //Field offset: 0x4C
	private float m_PassTime; //Field offset: 0x50
	private int m_PassTimeId; //Field offset: 0x54
	private RenderTexture m_RenderTexture; //Field offset: 0x58
	private int m_TotalTimeId; //Field offset: 0x60
	private int m_Width; //Field offset: 0x64
	public float totalTime; //Field offset: 0x68

	public GradientFogOptmization() { }

	public virtual bool CheckResources() { }

	private void EnableFog(bool enable) { }

	protected virtual void OnDestroy() { }

	private void OnPostRender() { }

	private void OnPreRender() { }

	protected virtual void Start() { }

	private void Update() { }

}

