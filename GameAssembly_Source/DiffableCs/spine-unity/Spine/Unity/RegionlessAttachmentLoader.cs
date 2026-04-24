namespace Spine.Unity;

public class RegionlessAttachmentLoader : AttachmentLoader
{
	private static AtlasRegion emptyRegion; //Field offset: 0x64980

	private static AtlasRegion EmptyRegion
	{
		private get { } //Length: 352
	}

	public RegionlessAttachmentLoader() { }

	private static AtlasRegion get_EmptyRegion() { }

	public override BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

	public override ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

	public override MeshAttachment NewMeshAttachment(Skin skin, string name, string path) { }

	public override PathAttachment NewPathAttachment(Skin skin, string name) { }

	public override PointAttachment NewPointAttachment(Skin skin, string name) { }

	public override RegionAttachment NewRegionAttachment(Skin skin, string name, string path) { }

}

