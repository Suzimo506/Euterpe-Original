namespace UnityEngine.PostProcessing;

public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
{
	private static class Uniforms
	{
		internal static readonly int _Grain_Params1; //Field offset: 0x0
		internal static readonly int _Grain_Params2; //Field offset: 0x4
		internal static readonly int _GrainTex; //Field offset: 0x8
		internal static readonly int _Phase; //Field offset: 0xC

		private static Uniforms() { }

	}

	private RenderTexture m_GrainLookupRT; //Field offset: 0x20

	public virtual bool active
	{
		 get { } //Length: 113
	}

	public GrainComponent() { }

	public virtual bool get_active() { }

	public virtual void OnDisable() { }

	public virtual void Prepare(Material uberMaterial) { }

}

