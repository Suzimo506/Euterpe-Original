namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRIOBuffer
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _Close : MulticastDelegate
	{

		public _Close(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulBuffer, AsyncCallback callback, object object) { }

		public override EIOBufferError EndInvoke(IAsyncResult result) { }

		public override EIOBufferError Invoke(ulong ulBuffer) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _Open : MulticastDelegate
	{

		public _Open(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer, AsyncCallback callback, object object) { }

		public override EIOBufferError EndInvoke(ref ulong pulBuffer, IAsyncResult result) { }

		public override EIOBufferError Invoke(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PropertyContainer : MulticastDelegate
	{

		public _PropertyContainer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulBuffer, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke(ulong ulBuffer) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _Read : MulticastDelegate
	{

		public _Read(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead, AsyncCallback callback, object object) { }

		public override EIOBufferError EndInvoke(ref uint punRead, IAsyncResult result) { }

		public override EIOBufferError Invoke(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _Write : MulticastDelegate
	{

		public _Write(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulBuffer, IntPtr pSrc, uint unBytes, AsyncCallback callback, object object) { }

		public override EIOBufferError EndInvoke(IAsyncResult result) { }

		public override EIOBufferError Invoke(ulong ulBuffer, IntPtr pSrc, uint unBytes) { }

	}

	internal _Open Open; //Field offset: 0x0
	internal _Close Close; //Field offset: 0x8
	internal _Read Read; //Field offset: 0x10
	internal _Write Write; //Field offset: 0x18
	internal _PropertyContainer PropertyContainer; //Field offset: 0x20

}

