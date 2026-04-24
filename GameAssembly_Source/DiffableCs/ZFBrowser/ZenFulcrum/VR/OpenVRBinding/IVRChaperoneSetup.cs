namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRChaperoneSetup
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CommitWorkingCopy : MulticastDelegate
	{

		public _CommitWorkingCopy(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EChaperoneConfigFile configFile, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(EChaperoneConfigFile configFile) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ExportLiveToBuffer : MulticastDelegate
	{

		public _ExportLiveToBuffer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StringBuilder pBuffer, ref uint pnBufferLength, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref uint pnBufferLength, IAsyncResult result) { }

		public override bool Invoke(StringBuilder pBuffer, ref uint pnBufferLength) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetLiveCollisionBoundsInfo : MulticastDelegate
	{

		public _GetLiveCollisionBoundsInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref uint punQuadsCount, IAsyncResult result) { }

		public override bool Invoke(out HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetLiveSeatedZeroPoseToRawTrackingPose : MulticastDelegate
	{

		public _GetLiveSeatedZeroPoseToRawTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose, IAsyncResult result) { }

		public override bool Invoke(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetWorkingCollisionBoundsInfo : MulticastDelegate
	{

		public _GetWorkingCollisionBoundsInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref uint punQuadsCount, IAsyncResult result) { }

		public override bool Invoke(out HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetWorkingPlayAreaRect : MulticastDelegate
	{

		public _GetWorkingPlayAreaRect(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdQuad_t rect, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref HmdQuad_t rect, IAsyncResult result) { }

		public override bool Invoke(ref HmdQuad_t rect) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetWorkingPlayAreaSize : MulticastDelegate
	{

		public _GetWorkingPlayAreaSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref float pSizeX, ref float pSizeZ, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref float pSizeX, ref float pSizeZ, IAsyncResult result) { }

		public override bool Invoke(ref float pSizeX, ref float pSizeZ) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetWorkingSeatedZeroPoseToRawTrackingPose : MulticastDelegate
	{

		public _GetWorkingSeatedZeroPoseToRawTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose, IAsyncResult result) { }

		public override bool Invoke(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetWorkingStandingZeroPoseToRawTrackingPose : MulticastDelegate
	{

		public _GetWorkingStandingZeroPoseToRawTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose, IAsyncResult result) { }

		public override bool Invoke(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _HideWorkingSetPreview : MulticastDelegate
	{

		public _HideWorkingSetPreview(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ImportFromBufferToWorking : MulticastDelegate
	{

		public _ImportFromBufferToWorking(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pBuffer, uint nImportFlags, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pBuffer, uint nImportFlags) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReloadFromDisk : MulticastDelegate
	{

		public _ReloadFromDisk(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EChaperoneConfigFile configFile, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EChaperoneConfigFile configFile) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RevertWorkingCopy : MulticastDelegate
	{

		public _RevertWorkingCopy(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetWorkingCollisionBoundsInfo : MulticastDelegate
	{

		public _SetWorkingCollisionBoundsInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out HmdQuad_t[] pQuadsBuffer, uint unQuadsCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(out HmdQuad_t[] pQuadsBuffer, uint unQuadsCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetWorkingPerimeter : MulticastDelegate
	{

		public _SetWorkingPerimeter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(out HmdVector2_t[] pPointBuffer, uint unPointCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(out HmdVector2_t[] pPointBuffer, uint unPointCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetWorkingPlayAreaSize : MulticastDelegate
	{

		public _SetWorkingPlayAreaSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(float sizeX, float sizeZ, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(float sizeX, float sizeZ) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetWorkingSeatedZeroPoseToRawTrackingPose : MulticastDelegate
	{

		public _SetWorkingSeatedZeroPoseToRawTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose, IAsyncResult result) { }

		public override void Invoke(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetWorkingStandingZeroPoseToRawTrackingPose : MulticastDelegate
	{

		public _SetWorkingStandingZeroPoseToRawTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose, IAsyncResult result) { }

		public override void Invoke(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowWorkingSetPreview : MulticastDelegate
	{

		public _ShowWorkingSetPreview(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal _CommitWorkingCopy CommitWorkingCopy; //Field offset: 0x0
	internal _RevertWorkingCopy RevertWorkingCopy; //Field offset: 0x8
	internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize; //Field offset: 0x10
	internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect; //Field offset: 0x18
	internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo; //Field offset: 0x20
	internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo; //Field offset: 0x28
	internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose; //Field offset: 0x30
	internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose; //Field offset: 0x38
	internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize; //Field offset: 0x40
	internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo; //Field offset: 0x48
	internal _SetWorkingPerimeter SetWorkingPerimeter; //Field offset: 0x50
	internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose; //Field offset: 0x58
	internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose; //Field offset: 0x60
	internal _ReloadFromDisk ReloadFromDisk; //Field offset: 0x68
	internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose; //Field offset: 0x70
	internal _ExportLiveToBuffer ExportLiveToBuffer; //Field offset: 0x78
	internal _ImportFromBufferToWorking ImportFromBufferToWorking; //Field offset: 0x80
	internal _ShowWorkingSetPreview ShowWorkingSetPreview; //Field offset: 0x88
	internal _HideWorkingSetPreview HideWorkingSetPreview; //Field offset: 0x90

}

