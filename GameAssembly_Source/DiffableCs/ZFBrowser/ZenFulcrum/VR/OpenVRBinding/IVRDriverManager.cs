namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRDriverManager
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDriverCount : MulticastDelegate
	{

		public _GetDriverCount(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDriverHandle : MulticastDelegate
	{

		public _GetDriverHandle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchDriverName, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke(string pchDriverName) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDriverName : MulticastDelegate
	{

		public _GetDriverName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint nDriver, StringBuilder pchValue, uint unBufferSize, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(uint nDriver, StringBuilder pchValue, uint unBufferSize) { }

	}

	internal _GetDriverCount GetDriverCount; //Field offset: 0x0
	internal _GetDriverName GetDriverName; //Field offset: 0x8
	internal _GetDriverHandle GetDriverHandle; //Field offset: 0x10

}

