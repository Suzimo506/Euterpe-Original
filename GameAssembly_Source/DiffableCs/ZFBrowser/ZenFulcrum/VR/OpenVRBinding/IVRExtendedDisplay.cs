namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRExtendedDisplay
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDXGIOutputInfo : MulticastDelegate
	{

		public _GetDXGIOutputInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref int pnAdapterIndex, ref int pnAdapterOutputIndex, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref int pnAdapterIndex, ref int pnAdapterOutputIndex, IAsyncResult result) { }

		public override void Invoke(ref int pnAdapterIndex, ref int pnAdapterOutputIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetEyeOutputViewport : MulticastDelegate
	{

		public _GetEyeOutputViewport(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight, IAsyncResult result) { }

		public override void Invoke(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetWindowBounds : MulticastDelegate
	{

		public _GetWindowBounds(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight, IAsyncResult result) { }

		public override void Invoke(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight) { }

	}

	internal _GetWindowBounds GetWindowBounds; //Field offset: 0x0
	internal _GetEyeOutputViewport GetEyeOutputViewport; //Field offset: 0x8
	internal _GetDXGIOutputInfo GetDXGIOutputInfo; //Field offset: 0x10

}

