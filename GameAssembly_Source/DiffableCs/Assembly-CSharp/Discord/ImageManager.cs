namespace Discord;

public class ImageManager
{
	internal sealed class FetchHandler : MulticastDelegate
	{

		public FetchHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result, ImageHandle handleResult) { }

	}

	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchCallback : MulticastDelegate
		{

			public FetchCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ImageHandle handleResult) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchMethod : MulticastDelegate
		{

			public FetchMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetDataMethod : MulticastDelegate
		{

			public GetDataMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ImageHandle handle, Byte[] data, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetDimensionsMethod : MulticastDelegate
		{

			public GetDimensionsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref ImageDimensions dimensions, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions) { }

		}

		internal FetchMethod Fetch; //Field offset: 0x0
		internal GetDimensionsMethod GetDimensions; //Field offset: 0x8
		internal GetDataMethod GetData; //Field offset: 0x10

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18

	private FFIMethods Methods
	{
		private get { } //Length: 264
	}

	internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback) { }

	public void Fetch(ImageHandle handle, FetchHandler callback) { }

	[MonoPInvokeCallback]
	private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult) { }

	private FFIMethods get_Methods() { }

	public void GetData(ImageHandle handle, Byte[] data) { }

	public Byte[] GetData(ImageHandle handle) { }

	public ImageDimensions GetDimensions(ImageHandle handle) { }

	public Texture2D GetTexture(ImageHandle handle) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

}

