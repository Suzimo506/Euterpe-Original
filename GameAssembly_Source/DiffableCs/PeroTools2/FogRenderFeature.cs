//Type is in global namespace

public class FogRenderFeature : ScriptableRendererFeature
{
	internal struct FogSetting
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float density; //Field offset: 0x0
		public float near; //Field offset: 0x4
		public float far; //Field offset: 0x8
		public bool renderOnSkybox; //Field offset: 0xC
		public Gradient fog; //Field offset: 0x10
		[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float horizontalSize; //Field offset: 0x18
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float horizontalOffset; //Field offset: 0x1C

	}

	private FogRenderPass m_Pass; //Field offset: 0x20
	[SerializeField]
	public FogSetting setting; //Field offset: 0x28

	public FogRenderFeature() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

}

