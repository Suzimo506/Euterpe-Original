namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRResources
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetResourceFullPath : MulticastDelegate
	{

		public _GetResourceFullPath(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LoadSharedResource : MulticastDelegate
	{

		public _LoadSharedResource(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchResourceName, string pchBuffer, uint unBufferLen, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchResourceName, string pchBuffer, uint unBufferLen) { }

	}

	internal _LoadSharedResource LoadSharedResource; //Field offset: 0x0
	internal _GetResourceFullPath GetResourceFullPath; //Field offset: 0x8

}

