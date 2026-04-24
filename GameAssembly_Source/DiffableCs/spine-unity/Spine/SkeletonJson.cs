namespace Spine;

public class SkeletonJson
{
	public class LinkedMesh
	{
		internal string parent; //Field offset: 0x10
		internal string skin; //Field offset: 0x18
		internal int slotIndex; //Field offset: 0x20
		internal MeshAttachment mesh; //Field offset: 0x28
		internal bool inheritDeform; //Field offset: 0x30

		public LinkedMesh(MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritDeform) { }

	}

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

	public SkeletonJson(Atlas[] atlasArray) { }

	public SkeletonJson(AttachmentLoader attachmentLoader) { }

	[CompilerGenerated]
	public float get_Scale() { }

	private static bool GetBoolean(Dictionary<String, Object> map, string name, bool defaultValue) { }

	private static float GetFloat(Dictionary<String, Object> map, string name, float defaultValue) { }

	private static Single[] GetFloatArray(Dictionary<String, Object> map, string name, float scale) { }

	private static int GetInt(Dictionary<String, Object> map, string name, int defaultValue) { }

	private static Int32[] GetIntArray(Dictionary<String, Object> map, string name) { }

	private static string GetString(Dictionary<String, Object> map, string name, string defaultValue) { }

	private void ReadAnimation(Dictionary<String, Object> map, string name, SkeletonData skeletonData) { }

	private Attachment ReadAttachment(Dictionary<String, Object> map, Skin skin, int slotIndex, string name, SkeletonData skeletonData) { }

	private static void ReadCurve(Dictionary<String, Object> valueMap, CurveTimeline timeline, int frameIndex) { }

	public SkeletonData ReadSkeletonData(TextReader reader) { }

	public SkeletonData ReadSkeletonData(string path) { }

	private void ReadVertices(Dictionary<String, Object> map, VertexAttachment attachment, int verticesLength) { }

	[CompilerGenerated]
	public void set_Scale(float value) { }

	private static float ToColor(string hexString, int colorIndex, int expectedLength = 8) { }

}

