namespace UnityEngine.PostProcessing;

public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
{
	private static class Uniforms
	{
		internal static readonly int _FogColor; //Field offset: 0x0
		internal static readonly int _Density; //Field offset: 0x4
		internal static readonly int _Start; //Field offset: 0x8
		internal static readonly int _End; //Field offset: 0xC
		internal static readonly int _TempRT; //Field offset: 0x10

		private static Uniforms() { }

	}

	private const string k_ShaderString = "Hidden/Post FX/Fog"; //Field offset: 0x0

	public virtual bool active
	{
		 get { } //Length: 127
	}

	public FogComponent() { }

	public virtual bool get_active() { }

	public virtual CameraEvent GetCameraEvent() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual string GetName() { }

	public virtual void PopulateCommandBuffer(CommandBuffer cb) { }

}

