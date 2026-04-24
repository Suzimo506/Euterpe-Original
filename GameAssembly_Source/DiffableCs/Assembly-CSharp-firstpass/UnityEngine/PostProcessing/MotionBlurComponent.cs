namespace UnityEngine.PostProcessing;

public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
{
	internal class FrameBlendingFilter
	{
		private struct Frame
		{
			public RenderTexture lumaTexture; //Field offset: 0x0
			public RenderTexture chromaTexture; //Field offset: 0x8
			private float m_Time; //Field offset: 0x10
			private RenderTargetIdentifier[] m_MRT; //Field offset: 0x18

			public float CalculateWeight(float strength, float currentTime) { }

			public void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material) { }

			public void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format) { }

			public void Release() { }

		}

		private bool m_UseCompression; //Field offset: 0x10
		private RenderTextureFormat m_RawTextureFormat; //Field offset: 0x14
		private Frame[] m_FrameList; //Field offset: 0x18
		private int m_LastFrameCount; //Field offset: 0x20

		public FrameBlendingFilter() { }

		public void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material) { }

		private static bool CheckSupportCompression() { }

		public void Dispose() { }

		private Frame GetFrameRelative(int offset) { }

		private static RenderTextureFormat GetPreferredRenderTextureFormat() { }

		public void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material) { }

	}

	private enum Pass
	{
		VelocitySetup = 0,
		TileMax1 = 1,
		TileMax2 = 2,
		TileMaxV = 3,
		NeighborMax = 4,
		Reconstruction = 5,
		FrameCompression = 6,
		FrameBlendingChroma = 7,
		FrameBlendingRaw = 8,
	}

	internal class ReconstructionFilter
	{
		private RenderTextureFormat m_VectorRTFormat; //Field offset: 0x10
		private RenderTextureFormat m_PackedRTFormat; //Field offset: 0x14

		public ReconstructionFilter() { }

		private void CheckTextureFormatSupport() { }

		public bool IsSupported() { }

		public void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material) { }

	}

	private static class Uniforms
	{
		internal static readonly int _VelocityScale; //Field offset: 0x0
		internal static readonly int _MaxBlurRadius; //Field offset: 0x4
		internal static readonly int _RcpMaxBlurRadius; //Field offset: 0x8
		internal static readonly int _VelocityTex; //Field offset: 0xC
		internal static readonly int _MainTex; //Field offset: 0x10
		internal static readonly int _Tile2RT; //Field offset: 0x14
		internal static readonly int _Tile4RT; //Field offset: 0x18
		internal static readonly int _Tile8RT; //Field offset: 0x1C
		internal static readonly int _TileMaxOffs; //Field offset: 0x20
		internal static readonly int _TileMaxLoop; //Field offset: 0x24
		internal static readonly int _TileVRT; //Field offset: 0x28
		internal static readonly int _NeighborMaxTex; //Field offset: 0x2C
		internal static readonly int _LoopCount; //Field offset: 0x30
		internal static readonly int _TempRT; //Field offset: 0x34
		internal static readonly int _History1LumaTex; //Field offset: 0x38
		internal static readonly int _History2LumaTex; //Field offset: 0x3C
		internal static readonly int _History3LumaTex; //Field offset: 0x40
		internal static readonly int _History4LumaTex; //Field offset: 0x44
		internal static readonly int _History1ChromaTex; //Field offset: 0x48
		internal static readonly int _History2ChromaTex; //Field offset: 0x4C
		internal static readonly int _History3ChromaTex; //Field offset: 0x50
		internal static readonly int _History4ChromaTex; //Field offset: 0x54
		internal static readonly int _History1Weight; //Field offset: 0x58
		internal static readonly int _History2Weight; //Field offset: 0x5C
		internal static readonly int _History3Weight; //Field offset: 0x60
		internal static readonly int _History4Weight; //Field offset: 0x64

		private static Uniforms() { }

	}

	private ReconstructionFilter m_ReconstructionFilter; //Field offset: 0x20
	private FrameBlendingFilter m_FrameBlendingFilter; //Field offset: 0x28
	private bool m_FirstFrame; //Field offset: 0x30

	public virtual bool active
	{
		 get { } //Length: 182
	}

	public FrameBlendingFilter frameBlendingFilter
	{
		 get { } //Length: 373
	}

	public ReconstructionFilter reconstructionFilter
	{
		 get { } //Length: 141
	}

	public MotionBlurComponent() { }

	public virtual bool get_active() { }

	public FrameBlendingFilter get_frameBlendingFilter() { }

	public ReconstructionFilter get_reconstructionFilter() { }

	public virtual CameraEvent GetCameraEvent() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual string GetName() { }

	public virtual void OnDisable() { }

	public virtual void OnEnable() { }

	public virtual void PopulateCommandBuffer(CommandBuffer cb) { }

	public void ResetHistory() { }

}

