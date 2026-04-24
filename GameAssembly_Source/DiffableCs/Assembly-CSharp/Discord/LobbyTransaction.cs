namespace Discord;

public struct LobbyTransaction
{
	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DeleteMetadataMethod : MulticastDelegate
		{

			public DeleteMetadataMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string key) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetCapacityMethod : MulticastDelegate
		{

			public SetCapacityMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint capacity, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, uint capacity) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetLockedMethod : MulticastDelegate
		{

			public SetLockedMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, bool locked) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetMetadataMethod : MulticastDelegate
		{

			public SetMetadataMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string key, string value) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetOwnerMethod : MulticastDelegate
		{

			public SetOwnerMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long ownerId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long ownerId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetTypeMethod : MulticastDelegate
		{

			public SetTypeMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbyType type, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, LobbyType type) { }

		}

		internal SetTypeMethod SetType; //Field offset: 0x0
		internal SetOwnerMethod SetOwner; //Field offset: 0x8
		internal SetCapacityMethod SetCapacity; //Field offset: 0x10
		internal SetMetadataMethod SetMetadata; //Field offset: 0x18
		internal DeleteMetadataMethod DeleteMetadata; //Field offset: 0x20
		internal SetLockedMethod SetLocked; //Field offset: 0x28

	}

	internal IntPtr MethodsPtr; //Field offset: 0x0
	internal object MethodsStructure; //Field offset: 0x8

	private FFIMethods Methods
	{
		private get { } //Length: 269
	}

	public void DeleteMetadata(string key) { }

	private FFIMethods get_Methods() { }

	public void SetCapacity(uint capacity) { }

	public void SetLocked(bool locked) { }

	public void SetMetadata(string key, string value) { }

	public void SetOwner(long ownerId) { }

	public void SetType(LobbyType type) { }

}

