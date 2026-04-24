namespace UnityEngine.PostProcessing;

public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
{
	private static class Uniforms
	{
		internal static readonly int _QualitySettings; //Field offset: 0x0
		internal static readonly int _ConsoleSettings; //Field offset: 0x4

		private static Uniforms() { }

	}


	public virtual bool active
	{
		 get { } //Length: 93
	}

	public FxaaComponent() { }

	public virtual bool get_active() { }

	public void Render(RenderTexture source, RenderTexture destination) { }

}

