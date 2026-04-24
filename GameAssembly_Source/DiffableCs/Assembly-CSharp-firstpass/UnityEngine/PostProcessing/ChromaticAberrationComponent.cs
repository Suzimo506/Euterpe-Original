namespace UnityEngine.PostProcessing;

public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
{
	private static class Uniforms
	{
		internal static readonly int _ChromaticAberration_Amount; //Field offset: 0x0
		internal static readonly int _ChromaticAberration_Spectrum; //Field offset: 0x4

		private static Uniforms() { }

	}

	private Texture2D m_SpectrumLut; //Field offset: 0x20

	public virtual bool active
	{
		 get { } //Length: 99
	}

	public ChromaticAberrationComponent() { }

	public virtual bool get_active() { }

	public virtual void OnDisable() { }

	public virtual void Prepare(Material uberMaterial) { }

}

