namespace Spine.Unity.AttachmentTools;

[Extension]
public static class AttachmentCloneExtensions
{

	[Extension]
	public static Attachment GetCopy(Attachment o, bool cloneMeshesAsLinked) { }

	[Extension]
	public static MeshAttachment GetLinkedMesh(MeshAttachment o, string newLinkedMeshName, AtlasRegion region) { }

	[Extension]
	public static MeshAttachment GetLinkedMesh(MeshAttachment o, Sprite sprite, Shader shader, Material materialPropertySource = null) { }

	[Extension]
	public static MeshAttachment GetLinkedMesh(MeshAttachment o, Sprite sprite, Material materialPropertySource) { }

	[Extension]
	public static Attachment GetRemappedClone(Attachment o, Sprite sprite, Material sourceMaterial, bool premultiplyAlpha = true, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, bool pivotShiftsMeshUVCoords = true) { }

	[Extension]
	public static Attachment GetRemappedClone(Attachment o, AtlasRegion atlasRegion, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, float scale = 0.01) { }

}

