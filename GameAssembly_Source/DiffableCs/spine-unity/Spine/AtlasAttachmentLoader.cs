namespace Spine;

public class AtlasAttachmentLoader : AttachmentLoader
{
	private Atlas[] atlasArray; //Field offset: 0x10

	public AtlasAttachmentLoader(Atlas[] atlasArray) { }

	public AtlasRegion FindRegion(string name) { }

	public override BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

	public override ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

	public override MeshAttachment NewMeshAttachment(Skin skin, string name, string path) { }

	public override PathAttachment NewPathAttachment(Skin skin, string name) { }

	public override PointAttachment NewPointAttachment(Skin skin, string name) { }

	public override RegionAttachment NewRegionAttachment(Skin skin, string name, string path) { }

}

