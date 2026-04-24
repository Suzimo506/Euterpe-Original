namespace Discord;

public class RelationshipManager
{
	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class RefreshHandler : MulticastDelegate
		{

			public RefreshHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class RelationshipUpdateHandler : MulticastDelegate
		{

			public RelationshipUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ref Relationship relationship, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref Relationship relationship, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ref Relationship relationship) { }

		}

		internal RefreshHandler OnRefresh; //Field offset: 0x0
		internal RelationshipUpdateHandler OnRelationshipUpdate; //Field offset: 0x8

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CountMethod : MulticastDelegate
		{

			public CountMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref int count, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FilterCallback : MulticastDelegate
		{

			public FilterCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ref Relationship relationship, AsyncCallback callback, object object) { }

			public override bool EndInvoke(ref Relationship relationship, IAsyncResult result) { }

			public override bool Invoke(IntPtr ptr, ref Relationship relationship) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FilterMethod : MulticastDelegate
		{

			public FilterMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FilterCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FilterCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetAtMethod : MulticastDelegate
		{

			public GetAtMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint index, ref Relationship relationship, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Relationship relationship, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, uint index, ref Relationship relationship) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetMethod : MulticastDelegate
		{

			public GetMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref Relationship relationship, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Relationship relationship, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long userId, ref Relationship relationship) { }

		}

		internal FilterMethod Filter; //Field offset: 0x0
		internal CountMethod Count; //Field offset: 0x8
		internal GetMethod Get; //Field offset: 0x10
		internal GetAtMethod GetAt; //Field offset: 0x18

	}

	internal sealed class FilterHandler : MulticastDelegate
	{

		public FilterHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Relationship relationship, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref Relationship relationship, IAsyncResult result) { }

		public override bool Invoke(ref Relationship relationship) { }

	}

	internal sealed class RefreshHandler : MulticastDelegate
	{

		public RefreshHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class RelationshipUpdateHandler : MulticastDelegate
	{

		public RelationshipUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Relationship relationship, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Relationship relationship, IAsyncResult result) { }

		public override void Invoke(ref Relationship relationship) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private RefreshHandler OnRefresh; //Field offset: 0x20
	[CompilerGenerated]
	private RelationshipUpdateHandler OnRelationshipUpdate; //Field offset: 0x28

	public event RefreshHandler OnRefresh
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event RelationshipUpdateHandler OnRelationshipUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 262
	}

	internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnRefresh(RefreshHandler value) { }

	[CompilerGenerated]
	public void add_OnRelationshipUpdate(RelationshipUpdateHandler value) { }

	public int Count() { }

	public void Filter(FilterHandler callback) { }

	[MonoPInvokeCallback]
	private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship) { }

	public Relationship Get(long userId) { }

	private FFIMethods get_Methods() { }

	public Relationship GetAt(uint index) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[MonoPInvokeCallback]
	private static void OnRefreshImpl(IntPtr ptr) { }

	[MonoPInvokeCallback]
	private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship) { }

	[CompilerGenerated]
	public void remove_OnRefresh(RefreshHandler value) { }

	[CompilerGenerated]
	public void remove_OnRelationshipUpdate(RelationshipUpdateHandler value) { }

}

