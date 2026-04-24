namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRSpatialAnchors
{
	private IVRSpatialAnchors FnTable; //Field offset: 0x10

	internal CVRSpatialAnchors(IntPtr pInterface) { }

	public EVRSpatialAnchorError CreateSpatialAnchorFromDescriptor(string pchDescriptor, ref uint pHandleOut) { }

	public EVRSpatialAnchorError CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut) { }

	public EVRSpatialAnchorError GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut) { }

	public EVRSpatialAnchorError GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut) { }

}

