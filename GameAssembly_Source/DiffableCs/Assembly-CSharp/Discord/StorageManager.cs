namespace Discord;

public class StorageManager
{
	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CountMethod : MulticastDelegate
		{

			public CountMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref int count, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DeleteMethod : MulticastDelegate
		{

			public DeleteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string name) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ExistsMethod : MulticastDelegate
		{

			public ExistsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref bool exists, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref bool exists, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string name, ref bool exists) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetPathMethod : MulticastDelegate
		{

			public GetPathMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder path, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, StringBuilder path) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ReadAsyncCallback : MulticastDelegate
		{

			public ReadAsyncCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ReadAsyncMethod : MulticastDelegate
		{

			public ReadAsyncMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ReadAsyncPartialCallback : MulticastDelegate
		{

			public ReadAsyncPartialCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ReadAsyncPartialMethod : MulticastDelegate
		{

			public ReadAsyncPartialMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ReadMethod : MulticastDelegate
		{

			public ReadMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, ref uint read, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref uint read, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, ref uint read) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class StatAtMethod : MulticastDelegate
		{

			public StatAtMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref FileStat stat, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref FileStat stat, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, int index, ref FileStat stat) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class StatMethod : MulticastDelegate
		{

			public StatMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref FileStat stat, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref FileStat stat, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string name, ref FileStat stat) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class WriteAsyncCallback : MulticastDelegate
		{

			public WriteAsyncCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class WriteAsyncMethod : MulticastDelegate
		{

			public WriteAsyncMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class WriteMethod : MulticastDelegate
		{

			public WriteMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen) { }

		}

		internal ReadMethod Read; //Field offset: 0x0
		internal ReadAsyncMethod ReadAsync; //Field offset: 0x8
		internal ReadAsyncPartialMethod ReadAsyncPartial; //Field offset: 0x10
		internal WriteMethod Write; //Field offset: 0x18
		internal WriteAsyncMethod WriteAsync; //Field offset: 0x20
		internal DeleteMethod Delete; //Field offset: 0x28
		internal ExistsMethod Exists; //Field offset: 0x30
		internal CountMethod Count; //Field offset: 0x38
		internal StatMethod Stat; //Field offset: 0x40
		internal StatAtMethod StatAt; //Field offset: 0x48
		internal GetPathMethod GetPath; //Field offset: 0x50

	}

	internal sealed class ReadAsyncHandler : MulticastDelegate
	{

		public ReadAsyncHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, Byte[] data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result, Byte[] data) { }

	}

	internal sealed class ReadAsyncPartialHandler : MulticastDelegate
	{

		public ReadAsyncPartialHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, Byte[] data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result, Byte[] data) { }

	}

	internal sealed class WriteAsyncHandler : MulticastDelegate
	{

		public WriteAsyncHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18

	private FFIMethods Methods
	{
		private get { } //Length: 296
	}

	internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	public int Count() { }

	public void Delete(string name) { }

	public bool Exists(string name) { }

	public IEnumerable<FileStat> Files() { }

	private FFIMethods get_Methods() { }

	public string GetPath() { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	public uint Read(string name, Byte[] data) { }

	public void ReadAsync(string name, ReadAsyncHandler callback) { }

	[MonoPInvokeCallback]
	private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback) { }

	[MonoPInvokeCallback]
	private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	public FileStat Stat(string name) { }

	public FileStat StatAt(int index) { }

	public void Write(string name, Byte[] data) { }

	public void WriteAsync(string name, Byte[] data, WriteAsyncHandler callback) { }

	[MonoPInvokeCallback]
	private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result) { }

}

