namespace Discord;

public class LobbyManager
{
	internal sealed class ConnectLobbyHandler : MulticastDelegate
	{

		public ConnectLobbyHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Lobby lobby, IAsyncResult result) { }

		public override void Invoke(Result result, ref Lobby lobby) { }

	}

	internal sealed class ConnectLobbyWithActivitySecretHandler : MulticastDelegate
	{

		public ConnectLobbyWithActivitySecretHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Lobby lobby, IAsyncResult result) { }

		public override void Invoke(Result result, ref Lobby lobby) { }

	}

	internal sealed class ConnectVoiceHandler : MulticastDelegate
	{

		public ConnectVoiceHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class CreateLobbyHandler : MulticastDelegate
	{

		public CreateLobbyHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Lobby lobby, IAsyncResult result) { }

		public override void Invoke(Result result, ref Lobby lobby) { }

	}

	internal sealed class DeleteLobbyHandler : MulticastDelegate
	{

		public DeleteLobbyHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class DisconnectLobbyHandler : MulticastDelegate
	{

		public DisconnectLobbyHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class DisconnectVoiceHandler : MulticastDelegate
	{

		public DisconnectVoiceHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class LobbyDeleteHandler : MulticastDelegate
		{

			public LobbyDeleteHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, uint reason, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, uint reason) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class LobbyMessageHandler : MulticastDelegate
		{

			public LobbyMessageHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class LobbyUpdateHandler : MulticastDelegate
		{

			public LobbyUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class MemberConnectHandler : MulticastDelegate
		{

			public MemberConnectHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, long userId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class MemberDisconnectHandler : MulticastDelegate
		{

			public MemberDisconnectHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, long userId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class MemberUpdateHandler : MulticastDelegate
		{

			public MemberUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, long userId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class NetworkMessageHandler : MulticastDelegate
		{

			public NetworkMessageHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SpeakingHandler : MulticastDelegate
		{

			public SpeakingHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, bool speaking, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, long lobbyId, long userId, bool speaking) { }

		}

		internal LobbyUpdateHandler OnLobbyUpdate; //Field offset: 0x0
		internal LobbyDeleteHandler OnLobbyDelete; //Field offset: 0x8
		internal MemberConnectHandler OnMemberConnect; //Field offset: 0x10
		internal MemberUpdateHandler OnMemberUpdate; //Field offset: 0x18
		internal MemberDisconnectHandler OnMemberDisconnect; //Field offset: 0x20
		internal LobbyMessageHandler OnLobbyMessage; //Field offset: 0x28
		internal SpeakingHandler OnSpeaking; //Field offset: 0x30
		internal NetworkMessageHandler OnNetworkMessage; //Field offset: 0x38

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectLobbyCallback : MulticastDelegate
		{

			public ConnectLobbyCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref Lobby lobby, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ref Lobby lobby) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectLobbyMethod : MulticastDelegate
		{

			public ConnectLobbyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, ConnectLobbyCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, ConnectLobbyCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectLobbyWithActivitySecretCallback : MulticastDelegate
		{

			public ConnectLobbyWithActivitySecretCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref Lobby lobby, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ref Lobby lobby) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectLobbyWithActivitySecretMethod : MulticastDelegate
		{

			public ConnectLobbyWithActivitySecretMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, ConnectLobbyWithActivitySecretCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, ConnectLobbyWithActivitySecretCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectNetworkMethod : MulticastDelegate
		{

			public ConnectNetworkMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectVoiceCallback : MulticastDelegate
		{

			public ConnectVoiceCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class ConnectVoiceMethod : MulticastDelegate
		{

			public ConnectVoiceMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, ConnectVoiceCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, ConnectVoiceCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CreateLobbyCallback : MulticastDelegate
		{

			public CreateLobbyCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref Lobby lobby, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ref Lobby lobby) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CreateLobbyMethod : MulticastDelegate
		{

			public CreateLobbyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, CreateLobbyCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, CreateLobbyCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DeleteLobbyCallback : MulticastDelegate
		{

			public DeleteLobbyCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DeleteLobbyMethod : MulticastDelegate
		{

			public DeleteLobbyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DeleteLobbyCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DeleteLobbyCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DisconnectLobbyCallback : MulticastDelegate
		{

			public DisconnectLobbyCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DisconnectLobbyMethod : MulticastDelegate
		{

			public DisconnectLobbyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectLobbyCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectLobbyCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DisconnectNetworkMethod : MulticastDelegate
		{

			public DisconnectNetworkMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DisconnectVoiceCallback : MulticastDelegate
		{

			public DisconnectVoiceCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class DisconnectVoiceMethod : MulticastDelegate
		{

			public DisconnectVoiceMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectVoiceCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectVoiceCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FlushNetworkMethod : MulticastDelegate
		{

			public FlushNetworkMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyActivitySecretMethod : MulticastDelegate
		{

			public GetLobbyActivitySecretMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, StringBuilder secret, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, StringBuilder secret) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyCreateTransactionMethod : MulticastDelegate
		{

			public GetLobbyCreateTransactionMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref IntPtr transaction, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref IntPtr transaction, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref IntPtr transaction) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyIdMethod : MulticastDelegate
		{

			public GetLobbyIdMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref long lobbyId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref long lobbyId, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, int index, ref long lobbyId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyMetadataKeyMethod : MulticastDelegate
		{

			public GetLobbyMetadataKeyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyMetadataValueMethod : MulticastDelegate
		{

			public GetLobbyMetadataValueMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyMethod : MulticastDelegate
		{

			public GetLobbyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref Lobby lobby, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Lobby lobby, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, ref Lobby lobby) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetLobbyUpdateTransactionMethod : MulticastDelegate
		{

			public GetLobbyUpdateTransactionMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref IntPtr transaction, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetMemberMetadataKeyMethod : MulticastDelegate
		{

			public GetMemberMetadataKeyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetMemberMetadataValueMethod : MulticastDelegate
		{

			public GetMemberMetadataValueMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetMemberUpdateTransactionMethod : MulticastDelegate
		{

			public GetMemberUpdateTransactionMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref IntPtr transaction, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetMemberUserIdMethod : MulticastDelegate
		{

			public GetMemberUserIdMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, int index, ref long userId, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref long userId, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, int index, ref long userId) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetMemberUserMethod : MulticastDelegate
		{

			public GetMemberUserMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref User user, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref User user, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref User user) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetSearchQueryMethod : MulticastDelegate
		{

			public GetSearchQueryMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref IntPtr query, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref IntPtr query, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref IntPtr query) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class LobbyCountMethod : MulticastDelegate
		{

			public LobbyCountMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref int count, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class LobbyMetadataCountMethod : MulticastDelegate
		{

			public LobbyMetadataCountMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref int count, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref int count, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class MemberCountMethod : MulticastDelegate
		{

			public MemberCountMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref int count, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref int count, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class MemberMetadataCountMethod : MulticastDelegate
		{

			public MemberMetadataCountMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref int count, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref int count, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class OpenNetworkChannelMethod : MulticastDelegate
		{

			public OpenNetworkChannelMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SearchCallback : MulticastDelegate
		{

			public SearchCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SearchMethod : MulticastDelegate
		{

			public SearchMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, SearchCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, SearchCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendLobbyMessageCallback : MulticastDelegate
		{

			public SendLobbyMessageCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendLobbyMessageMethod : MulticastDelegate
		{

			public SendLobbyMessageMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, Byte[] data, int dataLen, IntPtr callbackData, SendLobbyMessageCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, Byte[] data, int dataLen, IntPtr callbackData, SendLobbyMessageCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SendNetworkMessageMethod : MulticastDelegate
		{

			public SendNetworkMessageMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, Byte[] data, int dataLen) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdateLobbyCallback : MulticastDelegate
		{

			public UpdateLobbyCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdateLobbyMethod : MulticastDelegate
		{

			public UpdateLobbyMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, UpdateLobbyCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, UpdateLobbyCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdateMemberCallback : MulticastDelegate
		{

			public UpdateMemberCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UpdateMemberMethod : MulticastDelegate
		{

			public UpdateMemberMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, UpdateMemberCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, UpdateMemberCallback callback) { }

		}

		internal GetLobbyCreateTransactionMethod GetLobbyCreateTransaction; //Field offset: 0x0
		internal GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction; //Field offset: 0x8
		internal GetMemberUpdateTransactionMethod GetMemberUpdateTransaction; //Field offset: 0x10
		internal CreateLobbyMethod CreateLobby; //Field offset: 0x18
		internal UpdateLobbyMethod UpdateLobby; //Field offset: 0x20
		internal DeleteLobbyMethod DeleteLobby; //Field offset: 0x28
		internal ConnectLobbyMethod ConnectLobby; //Field offset: 0x30
		internal ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret; //Field offset: 0x38
		internal DisconnectLobbyMethod DisconnectLobby; //Field offset: 0x40
		internal GetLobbyMethod GetLobby; //Field offset: 0x48
		internal GetLobbyActivitySecretMethod GetLobbyActivitySecret; //Field offset: 0x50
		internal GetLobbyMetadataValueMethod GetLobbyMetadataValue; //Field offset: 0x58
		internal GetLobbyMetadataKeyMethod GetLobbyMetadataKey; //Field offset: 0x60
		internal LobbyMetadataCountMethod LobbyMetadataCount; //Field offset: 0x68
		internal MemberCountMethod MemberCount; //Field offset: 0x70
		internal GetMemberUserIdMethod GetMemberUserId; //Field offset: 0x78
		internal GetMemberUserMethod GetMemberUser; //Field offset: 0x80
		internal GetMemberMetadataValueMethod GetMemberMetadataValue; //Field offset: 0x88
		internal GetMemberMetadataKeyMethod GetMemberMetadataKey; //Field offset: 0x90
		internal MemberMetadataCountMethod MemberMetadataCount; //Field offset: 0x98
		internal UpdateMemberMethod UpdateMember; //Field offset: 0xA0
		internal SendLobbyMessageMethod SendLobbyMessage; //Field offset: 0xA8
		internal GetSearchQueryMethod GetSearchQuery; //Field offset: 0xB0
		internal SearchMethod Search; //Field offset: 0xB8
		internal LobbyCountMethod LobbyCount; //Field offset: 0xC0
		internal GetLobbyIdMethod GetLobbyId; //Field offset: 0xC8
		internal ConnectVoiceMethod ConnectVoice; //Field offset: 0xD0
		internal DisconnectVoiceMethod DisconnectVoice; //Field offset: 0xD8
		internal ConnectNetworkMethod ConnectNetwork; //Field offset: 0xE0
		internal DisconnectNetworkMethod DisconnectNetwork; //Field offset: 0xE8
		internal FlushNetworkMethod FlushNetwork; //Field offset: 0xF0
		internal OpenNetworkChannelMethod OpenNetworkChannel; //Field offset: 0xF8
		internal SendNetworkMessageMethod SendNetworkMessage; //Field offset: 0x100

	}

	internal sealed class LobbyDeleteHandler : MulticastDelegate
	{

		public LobbyDeleteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, uint reason, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, uint reason) { }

	}

	internal sealed class LobbyMessageHandler : MulticastDelegate
	{

		public LobbyMessageHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, long userId, Byte[] data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, long userId, Byte[] data) { }

	}

	internal sealed class LobbyUpdateHandler : MulticastDelegate
	{

		public LobbyUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId) { }

	}

	internal sealed class MemberConnectHandler : MulticastDelegate
	{

		public MemberConnectHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, long userId) { }

	}

	internal sealed class MemberDisconnectHandler : MulticastDelegate
	{

		public MemberDisconnectHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, long userId) { }

	}

	internal sealed class MemberUpdateHandler : MulticastDelegate
	{

		public MemberUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, long userId) { }

	}

	internal sealed class NetworkMessageHandler : MulticastDelegate
	{

		public NetworkMessageHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, long userId, byte channelId, Byte[] data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, long userId, byte channelId, Byte[] data) { }

	}

	internal sealed class SearchHandler : MulticastDelegate
	{

		public SearchHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class SendLobbyMessageHandler : MulticastDelegate
	{

		public SendLobbyMessageHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class SpeakingHandler : MulticastDelegate
	{

		public SpeakingHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(long lobbyId, long userId, bool speaking, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(long lobbyId, long userId, bool speaking) { }

	}

	internal sealed class UpdateLobbyHandler : MulticastDelegate
	{

		public UpdateLobbyHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class UpdateMemberHandler : MulticastDelegate
	{

		public UpdateMemberHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private LobbyUpdateHandler OnLobbyUpdate; //Field offset: 0x20
	[CompilerGenerated]
	private LobbyDeleteHandler OnLobbyDelete; //Field offset: 0x28
	[CompilerGenerated]
	private MemberConnectHandler OnMemberConnect; //Field offset: 0x30
	[CompilerGenerated]
	private MemberUpdateHandler OnMemberUpdate; //Field offset: 0x38
	[CompilerGenerated]
	private MemberDisconnectHandler OnMemberDisconnect; //Field offset: 0x40
	[CompilerGenerated]
	private LobbyMessageHandler OnLobbyMessage; //Field offset: 0x48
	[CompilerGenerated]
	private SpeakingHandler OnSpeaking; //Field offset: 0x50
	[CompilerGenerated]
	private NetworkMessageHandler OnNetworkMessage; //Field offset: 0x58

	public event LobbyDeleteHandler OnLobbyDelete
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event LobbyMessageHandler OnLobbyMessage
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event LobbyUpdateHandler OnLobbyUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event MemberConnectHandler OnMemberConnect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event MemberDisconnectHandler OnMemberDisconnect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event MemberUpdateHandler OnMemberUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event NetworkMessageHandler OnNetworkMessage
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event SpeakingHandler OnSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 352
	}

	internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnLobbyDelete(LobbyDeleteHandler value) { }

	[CompilerGenerated]
	public void add_OnLobbyMessage(LobbyMessageHandler value) { }

	[CompilerGenerated]
	public void add_OnLobbyUpdate(LobbyUpdateHandler value) { }

	[CompilerGenerated]
	public void add_OnMemberConnect(MemberConnectHandler value) { }

	[CompilerGenerated]
	public void add_OnMemberDisconnect(MemberDisconnectHandler value) { }

	[CompilerGenerated]
	public void add_OnMemberUpdate(MemberUpdateHandler value) { }

	[CompilerGenerated]
	public void add_OnNetworkMessage(NetworkMessageHandler value) { }

	[CompilerGenerated]
	public void add_OnSpeaking(SpeakingHandler value) { }

	public void ConnectLobby(long lobbyId, string secret, ConnectLobbyHandler callback) { }

	[MonoPInvokeCallback]
	private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	public void ConnectLobbyWithActivitySecret(string activitySecret, ConnectLobbyWithActivitySecretHandler callback) { }

	[MonoPInvokeCallback]
	private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	public void ConnectNetwork(long lobbyId) { }

	public void ConnectVoice(long lobbyId, ConnectVoiceHandler callback) { }

	[MonoPInvokeCallback]
	private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result) { }

	public void CreateLobby(LobbyTransaction transaction, CreateLobbyHandler callback) { }

	[MonoPInvokeCallback]
	private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	public void DeleteLobby(long lobbyId, DeleteLobbyHandler callback) { }

	[MonoPInvokeCallback]
	private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result) { }

	public void DisconnectLobby(long lobbyId, DisconnectLobbyHandler callback) { }

	[MonoPInvokeCallback]
	private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result) { }

	public void DisconnectNetwork(long lobbyId) { }

	public void DisconnectVoice(long lobbyId, DisconnectVoiceHandler callback) { }

	[MonoPInvokeCallback]
	private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result) { }

	public void FlushNetwork() { }

	private FFIMethods get_Methods() { }

	public Lobby GetLobby(long lobbyId) { }

	public string GetLobbyActivitySecret(long lobbyId) { }

	public LobbyTransaction GetLobbyCreateTransaction() { }

	public long GetLobbyId(int index) { }

	public string GetLobbyMetadataKey(long lobbyId, int index) { }

	public string GetLobbyMetadataValue(long lobbyId, string key) { }

	public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId) { }

	public string GetMemberMetadataKey(long lobbyId, long userId, int index) { }

	public string GetMemberMetadataValue(long lobbyId, long userId, string key) { }

	public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId) { }

	public User GetMemberUser(long lobbyId, long userId) { }

	public long GetMemberUserId(long lobbyId, int index) { }

	public IEnumerable<User> GetMemberUsers(long lobbyID) { }

	public LobbySearchQuery GetSearchQuery() { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	public int LobbyCount() { }

	public int LobbyMetadataCount(long lobbyId) { }

	public int MemberCount(long lobbyId) { }

	public int MemberMetadataCount(long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason) { }

	[MonoPInvokeCallback]
	private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId) { }

	[MonoPInvokeCallback]
	private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking) { }

	public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable) { }

	[CompilerGenerated]
	public void remove_OnLobbyDelete(LobbyDeleteHandler value) { }

	[CompilerGenerated]
	public void remove_OnLobbyMessage(LobbyMessageHandler value) { }

	[CompilerGenerated]
	public void remove_OnLobbyUpdate(LobbyUpdateHandler value) { }

	[CompilerGenerated]
	public void remove_OnMemberConnect(MemberConnectHandler value) { }

	[CompilerGenerated]
	public void remove_OnMemberDisconnect(MemberDisconnectHandler value) { }

	[CompilerGenerated]
	public void remove_OnMemberUpdate(MemberUpdateHandler value) { }

	[CompilerGenerated]
	public void remove_OnNetworkMessage(NetworkMessageHandler value) { }

	[CompilerGenerated]
	public void remove_OnSpeaking(SpeakingHandler value) { }

	public void Search(LobbySearchQuery query, SearchHandler callback) { }

	[MonoPInvokeCallback]
	private static void SearchCallbackImpl(IntPtr ptr, Result result) { }

	public void SendLobbyMessage(long lobbyID, string data, SendLobbyMessageHandler handler) { }

	public void SendLobbyMessage(long lobbyId, Byte[] data, SendLobbyMessageHandler callback) { }

	[MonoPInvokeCallback]
	private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result) { }

	public void SendNetworkMessage(long lobbyId, long userId, byte channelId, Byte[] data) { }

	public void UpdateLobby(long lobbyId, LobbyTransaction transaction, UpdateLobbyHandler callback) { }

	[MonoPInvokeCallback]
	private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result) { }

	public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, UpdateMemberHandler callback) { }

	[MonoPInvokeCallback]
	private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result) { }

}

