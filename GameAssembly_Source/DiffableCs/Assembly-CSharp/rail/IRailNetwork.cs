namespace rail;

public interface IRailNetwork
{

	public RailResult AcceptRawSessionRequest(RailID local_peer, RailGamePeer remote_game_peer) { }

	public RailResult AcceptSessionRequest(RailID local_peer, RailID remote_peer) { }

	public RailResult BlockMessageType(RailID local_peer, uint message_type) { }

	public RailResult CloseSession(RailID local_peer, RailID remote_peer) { }

	public RailResult ForbidSessionRelay(bool forbid_relay) { }

	public RailResult GetSessionState(RailID remote_peer, RailNetworkSessionState session_state) { }

	public bool IsDataReady(RailID local_peer, out uint data_len, out uint message_type) { }

	public bool IsDataReady(RailID local_peer, out uint data_len) { }

	public RailResult ReadData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public RailResult ReadData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, Byte[] data_buf, uint data_len) { }

	public RailResult ResolveHostname(string domain, List<String> ip_list) { }

	public RailResult SendData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public RailResult SendData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public RailResult SendRawData(RailID local_peer, RailGamePeer remote_game_peer, Byte[] data_buf, uint data_len, bool reliable, uint message_type) { }

	public RailResult SendReliableData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public RailResult SendReliableData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public RailResult UnblockMessageType(RailID local_peer, uint message_type) { }

}

