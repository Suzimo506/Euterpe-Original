namespace Spine;

public class SkeletonBinary
{
	public class SkeletonInput
	{
		private Byte[] chars; //Field offset: 0x10
		private Byte[] bytesBigEndian; //Field offset: 0x18
		internal ExposedList<String> strings; //Field offset: 0x20
		private Stream input; //Field offset: 0x28

		public SkeletonInput(Stream input) { }

		public string GetVersionString() { }

		public bool ReadBoolean() { }

		public byte ReadByte() { }

		public float ReadFloat() { }

		public void ReadFully(Byte[] buffer, int offset, int length) { }

		public int ReadInt() { }

		public int ReadInt(bool optimizePositive) { }

		public sbyte ReadSByte() { }

		public string ReadString() { }

		public string ReadStringRef() { }

	}

	public class Vertices
	{
		public Int32[] bones; //Field offset: 0x10
		public Single[] vertices; //Field offset: 0x18

		public Vertices() { }

	}

	public const int BONE_ROTATE = 0; //Field offset: 0x0
	public const int CURVE_BEZIER = 2; //Field offset: 0x0
	public const int CURVE_STEPPED = 1; //Field offset: 0x0
	public const int CURVE_LINEAR = 0; //Field offset: 0x0
	public const int PATH_MIX = 2; //Field offset: 0x0
	public const int PATH_POSITION = 0; //Field offset: 0x0
	public const int PATH_SPACING = 1; //Field offset: 0x0
	public const int SLOT_COLOR = 1; //Field offset: 0x0
	public const int SLOT_ATTACHMENT = 0; //Field offset: 0x0
	public const int BONE_SHEAR = 3; //Field offset: 0x0
	public const int BONE_SCALE = 2; //Field offset: 0x0
	public const int BONE_TRANSLATE = 1; //Field offset: 0x0
	public const int SLOT_TWO_COLOR = 2; //Field offset: 0x0
	public static readonly TransformMode[] TransformModeValues; //Field offset: 0x0
	[CompilerGenerated]
	private float <Scale>k__BackingField; //Field offset: 0x10
	private AttachmentLoader attachmentLoader; //Field offset: 0x18
	private List<LinkedMesh> linkedMeshes; //Field offset: 0x20

	public float Scale
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private static SkeletonBinary() { }

	public SkeletonBinary(Atlas[] atlasArray) { }

	public SkeletonBinary(AttachmentLoader attachmentLoader) { }

	[CompilerGenerated]
	public float get_Scale() { }

	public static string GetVersionString(Stream file) { }

	private Animation ReadAnimation(string name, SkeletonInput input, SkeletonData skeletonData) { }

	private Attachment ReadAttachment(SkeletonInput input, SkeletonData skeletonData, Skin skin, int slotIndex, string attachmentName, bool nonessential) { }

	private void ReadCurve(SkeletonInput input, int frameIndex, CurveTimeline timeline) { }

	private Single[] ReadFloatArray(SkeletonInput input, int n, float scale) { }

	private Int32[] ReadShortArray(SkeletonInput input) { }

	public SkeletonData ReadSkeletonData(string path) { }

	public SkeletonData ReadSkeletonData(Stream file) { }

	private Skin ReadSkin(SkeletonInput input, SkeletonData skeletonData, bool defaultSkin, bool nonessential) { }

	private Vertices ReadVertices(SkeletonInput input, int vertexCount) { }

	[CompilerGenerated]
	public void set_Scale(float value) { }

}

