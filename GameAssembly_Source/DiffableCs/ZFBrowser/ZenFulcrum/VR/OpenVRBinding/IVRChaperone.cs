namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRChaperone
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _AreBoundsVisible : MulticastDelegate
	{

		public _AreBoundsVisible(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ForceBoundsVisible : MulticastDelegate
	{

		public _ForceBoundsVisible(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool bForce, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool bForce) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetBoundsColor : MulticastDelegate
	{

		public _GetBoundsColor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref HmdColor_t pOutputColorArray, ref HmdColor_t pOutputCameraColor, IAsyncResult result) { }

		public override void Invoke(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCalibrationState : MulticastDelegate
	{

		public _GetCalibrationState(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override ChaperoneCalibrationState EndInvoke(IAsyncResult result) { }

		public override ChaperoneCalibrationState Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetPlayAreaRect : MulticastDelegate
	{

		public _GetPlayAreaRect(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref HmdQuad_t rect, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref HmdQuad_t rect, IAsyncResult result) { }

		public override bool Invoke(ref HmdQuad_t rect) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetPlayAreaSize : MulticastDelegate
	{

		public _GetPlayAreaSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref float pSizeX, ref float pSizeZ, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref float pSizeX, ref float pSizeZ, IAsyncResult result) { }

		public override bool Invoke(ref float pSizeX, ref float pSizeZ) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReloadInfo : MulticastDelegate
	{

		public _ReloadInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetSceneColor : MulticastDelegate
	{

		public _SetSceneColor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(HmdColor_t color, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(HmdColor_t color) { }

	}

	internal _GetCalibrationState GetCalibrationState; //Field offset: 0x0
	internal _GetPlayAreaSize GetPlayAreaSize; //Field offset: 0x8
	internal _GetPlayAreaRect GetPlayAreaRect; //Field offset: 0x10
	internal _ReloadInfo ReloadInfo; //Field offset: 0x18
	internal _SetSceneColor SetSceneColor; //Field offset: 0x20
	internal _GetBoundsColor GetBoundsColor; //Field offset: 0x28
	internal _AreBoundsVisible AreBoundsVisible; //Field offset: 0x30
	internal _ForceBoundsVisible ForceBoundsVisible; //Field offset: 0x38

}

