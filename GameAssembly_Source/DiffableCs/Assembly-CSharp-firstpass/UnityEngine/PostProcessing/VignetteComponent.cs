namespace UnityEngine.PostProcessing;

public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
{
	private static class Uniforms
	{
		internal static readonly int _Vignette_Color; //Field offset: 0x0
		internal static readonly int _Vignette_Center; //Field offset: 0x4
		internal static readonly int _Vignette_Settings; //Field offset: 0x8
		internal static readonly int _Vignette_Mask; //Field offset: 0xC
		internal static readonly int _Vignette_Opacity; //Field offset: 0x10

		private static Uniforms() { }

	}


	public virtual bool active
	{
		 get { } //Length: 86
	}

	public VignetteComponent() { }

	public virtual bool get_active() { }

	public virtual void Prepare(Material uberMaterial) { }

}

