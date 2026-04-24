namespace Discord;

public struct LobbySearchQuery
{
	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DistanceMethod : MulticastDelegate
		{

			public DistanceMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbySearchDistance distance, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, LobbySearchDistance distance) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FilterMethod : MulticastDelegate
		{

			public FilterMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class LimitMethod : MulticastDelegate
		{

			public LimitMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint limit, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, uint limit) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SortMethod : MulticastDelegate
		{

			public SortMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value) { }

		}

		internal FilterMethod Filter; //Field offset: 0x0
		internal SortMethod Sort; //Field offset: 0x8
		internal LimitMethod Limit; //Field offset: 0x10
		internal DistanceMethod Distance; //Field offset: 0x18

	}

	internal IntPtr MethodsPtr; //Field offset: 0x0
	internal object MethodsStructure; //Field offset: 0x8

	private FFIMethods Methods
	{
		private get { } //Length: 261
	}

	public void Distance(LobbySearchDistance distance) { }

	public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

	private FFIMethods get_Methods() { }

	public void Limit(uint limit) { }

	public void Sort(string key, LobbySearchCast cast, string value) { }

}

