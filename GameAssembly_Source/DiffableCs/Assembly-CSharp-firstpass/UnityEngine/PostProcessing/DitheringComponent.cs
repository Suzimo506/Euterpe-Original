namespace UnityEngine.PostProcessing;

public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
{
	private static class Uniforms
	{
		internal static readonly int _DitheringTex; //Field offset: 0x0
		internal static readonly int _DitheringCoords; //Field offset: 0x4

		private static Uniforms() { }

	}

	private const int k_TextureCount = 64; //Field offset: 0x0
	private Texture2D[] noiseTextures; //Field offset: 0x20
	private int textureIndex; //Field offset: 0x28

	public virtual bool active
	{
		 get { } //Length: 86
	}

	public DitheringComponent() { }

	public virtual bool get_active() { }

	private void LoadNoiseTextures() { }

	public virtual void OnDisable() { }

	public virtual void Prepare(Material uberMaterial) { }

}

