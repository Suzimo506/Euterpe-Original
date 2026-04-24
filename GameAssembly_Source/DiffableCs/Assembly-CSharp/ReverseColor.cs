//Type is in global namespace

[ExecuteInEditMode]
public class ReverseColor : PostEffectsBase
{
	public Shader screenEffectShader; //Field offset: 0x28
	private Material m_ScreenEffectMaterial; //Field offset: 0x30
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float reverseValue; //Field offset: 0x38
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float gradualWidth; //Field offset: 0x3C
	private bool m_IsInverse; //Field offset: 0x40
	public bool pass; //Field offset: 0x41
	private int m_ReverseValueID; //Field offset: 0x44
	private int m_GradualWidthID; //Field offset: 0x48

	public Material material
	{
		 get { } //Length: 151
	}

	public ReverseColor() { }

	private void Awake() { }

	public Material get_material() { }

	private void OnRenderImage(RenderTexture src, RenderTexture dest) { }

	public void SetInverse(bool inverse) { }

}

