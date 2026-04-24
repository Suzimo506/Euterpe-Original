namespace Steamworks;

public class ISteamMatchmakingServerListResponse
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private sealed class InternalRefreshComplete : MulticastDelegate
	{

		public InternalRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private sealed class InternalServerFailedToRespond : MulticastDelegate
	{

		public InternalServerFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private sealed class InternalServerResponded : MulticastDelegate
	{

		public InternalServerResponded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	}

	internal sealed class RefreshComplete : MulticastDelegate
	{

		public RefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	}

	internal sealed class ServerFailedToRespond : MulticastDelegate
	{

		public ServerFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(HServerListRequest hRequest, int iServer) { }

	}

	internal sealed class ServerResponded : MulticastDelegate
	{

		public ServerResponded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(HServerListRequest hRequest, int iServer) { }

	}

	private class VTable
	{
		public InternalServerResponded m_VTServerResponded; //Field offset: 0x10
		public InternalServerFailedToRespond m_VTServerFailedToRespond; //Field offset: 0x18
		public InternalRefreshComplete m_VTRefreshComplete; //Field offset: 0x20

		public VTable() { }

	}

	private VTable m_VTable; //Field offset: 0x10
	private IntPtr m_pVTable; //Field offset: 0x18
	private GCHandle m_pGCHandle; //Field offset: 0x20
	private ServerResponded m_ServerResponded; //Field offset: 0x28
	private ServerFailedToRespond m_ServerFailedToRespond; //Field offset: 0x30
	private RefreshComplete m_RefreshComplete; //Field offset: 0x38

	public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete) { }

	protected virtual void Finalize() { }

	private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	public static IntPtr op_Explicit(ISteamMatchmakingServerListResponse that) { }

}

