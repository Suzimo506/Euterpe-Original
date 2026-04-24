namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRSpatialAnchors
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CreateSpatialAnchorFromDescriptor : MulticastDelegate
	{

		public _CreateSpatialAnchorFromDescriptor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchDescriptor, ref uint pHandleOut, AsyncCallback callback, object object) { }

		public override EVRSpatialAnchorError EndInvoke(ref uint pHandleOut, IAsyncResult result) { }

		public override EVRSpatialAnchorError Invoke(string pchDescriptor, ref uint pHandleOut) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CreateSpatialAnchorFromPose : MulticastDelegate
	{

		public _CreateSpatialAnchorFromPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut, AsyncCallback callback, object object) { }

		public override EVRSpatialAnchorError EndInvoke(ref SpatialAnchorPose_t pPose, ref uint pHandleOut, IAsyncResult result) { }

		public override EVRSpatialAnchorError Invoke(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSpatialAnchorDescriptor : MulticastDelegate
	{

		public _GetSpatialAnchorDescriptor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut, AsyncCallback callback, object object) { }

		public override EVRSpatialAnchorError EndInvoke(ref uint punDescriptorBufferLenInOut, IAsyncResult result) { }

		public override EVRSpatialAnchorError Invoke(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSpatialAnchorPose : MulticastDelegate
	{

		public _GetSpatialAnchorPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut, AsyncCallback callback, object object) { }

		public override EVRSpatialAnchorError EndInvoke(ref SpatialAnchorPose_t pPoseOut, IAsyncResult result) { }

		public override EVRSpatialAnchorError Invoke(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut) { }

	}

	internal _CreateSpatialAnchorFromDescriptor CreateSpatialAnchorFromDescriptor; //Field offset: 0x0
	internal _CreateSpatialAnchorFromPose CreateSpatialAnchorFromPose; //Field offset: 0x8
	internal _GetSpatialAnchorPose GetSpatialAnchorPose; //Field offset: 0x10
	internal _GetSpatialAnchorDescriptor GetSpatialAnchorDescriptor; //Field offset: 0x18

}

