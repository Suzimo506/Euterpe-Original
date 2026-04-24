namespace Steamworks;

public class ISteamMatchmakingPlayersResponse
{
	internal sealed class AddPlayerToList : MulticastDelegate
	{

		public AddPlayerToList(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchName, int nScore, float flTimePlayed, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string pchName, int nScore, float flTimePlayed) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class InternalAddPlayerToList : MulticastDelegate
	{

		public InternalAddPlayerToList(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class InternalPlayersFailedToRespond : MulticastDelegate
	{

		public InternalPlayersFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class InternalPlayersRefreshComplete : MulticastDelegate
	{

		public InternalPlayersRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	internal sealed class PlayersFailedToRespond : MulticastDelegate
	{

		public PlayersFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class PlayersRefreshComplete : MulticastDelegate
	{

		public PlayersRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private class VTable
	{
		public InternalAddPlayerToList m_VTAddPlayerToList; //Field offset: 0x10
		public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond; //Field offset: 0x18
		public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete; //Field offset: 0x20

		public VTable() { }

	}

	private VTable m_VTable; //Field offset: 0x10
	private IntPtr m_pVTable; //Field offset: 0x18
	private GCHandle m_pGCHandle; //Field offset: 0x20
	private AddPlayerToList m_AddPlayerToList; //Field offset: 0x28
	private PlayersFailedToRespond m_PlayersFailedToRespond; //Field offset: 0x30
	private PlayersRefreshComplete m_PlayersRefreshComplete; //Field offset: 0x38

	public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete) { }

	protected virtual void Finalize() { }

	private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	private void InternalOnPlayersFailedToRespond(IntPtr thisptr) { }

	private void InternalOnPlayersRefreshComplete(IntPtr thisptr) { }

	public static IntPtr op_Explicit(ISteamMatchmakingPlayersResponse that) { }

}

