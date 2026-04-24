namespace UnityEngine.PostProcessing;

public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
{
	private class ArrowArray
	{
		[CompilerGenerated]
		private Mesh <mesh>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private int <columnCount>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private int <rowCount>k__BackingField; //Field offset: 0x1C

		public private int columnCount
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private Mesh mesh
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private int rowCount
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public ArrowArray() { }

		public void BuildMesh(int columns, int rows) { }

		[CompilerGenerated]
		public int get_columnCount() { }

		[CompilerGenerated]
		public Mesh get_mesh() { }

		[CompilerGenerated]
		public int get_rowCount() { }

		public void Release() { }

		[CompilerGenerated]
		private void set_columnCount(int value) { }

		[CompilerGenerated]
		private void set_mesh(Mesh value) { }

		[CompilerGenerated]
		private void set_rowCount(int value) { }

	}

	private enum Pass
	{
		Depth = 0,
		Normals = 1,
		MovecOpacity = 2,
		MovecImaging = 3,
		MovecArrows = 4,
	}

	private static class Uniforms
	{
		internal static readonly int _DepthScale; //Field offset: 0x0
		internal static readonly int _TempRT; //Field offset: 0x4
		internal static readonly int _Opacity; //Field offset: 0x8
		internal static readonly int _MainTex; //Field offset: 0xC
		internal static readonly int _TempRT2; //Field offset: 0x10
		internal static readonly int _Amplitude; //Field offset: 0x14
		internal static readonly int _Scale; //Field offset: 0x18

		private static Uniforms() { }

	}

	private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views"; //Field offset: 0x0
	private ArrowArray m_Arrows; //Field offset: 0x20

	public virtual bool active
	{
		 get { } //Length: 81
	}

	public BuiltinDebugViewsComponent() { }

	private void DepthNormalsPass(CommandBuffer cb) { }

	private void DepthPass(CommandBuffer cb) { }

	public virtual bool get_active() { }

	public virtual CameraEvent GetCameraEvent() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual string GetName() { }

	private void MotionVectorsPass(CommandBuffer cb) { }

	public virtual void OnDisable() { }

	public virtual void PopulateCommandBuffer(CommandBuffer cb) { }

	private void PrepareArrows() { }

}

