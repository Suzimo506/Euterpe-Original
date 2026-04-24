namespace rail;

public class IRailNetworkImpl : RailObject, IRailNetwork
{

	internal IRailNetworkImpl(IntPtr cPtr) { }

	public override RailResult AcceptRawSessionRequest(RailID local_peer, RailGamePeer remote_game_peer) { }

	public override RailResult AcceptSessionRequest(RailID local_peer, RailID remote_peer) { }

	public override RailResult BlockMessageType(RailID local_peer, uint message_type) { }

	public override RailResult CloseSession(RailID local_peer, RailID remote_peer) { }

	protected virtual void Finalize() { }

	public override RailResult ForbidSessionRelay(bool forbid_relay) { }

	public override RailResult GetSessionState(RailID remote_peer, RailNetworkSessionState session_state) { }

	public override bool IsDataReady(RailID local_peer, out uint data_len, out uint message_type) { }

	public override bool IsDataReady(RailID local_peer, out uint data_len) { }

	public override RailResult ReadData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public override RailResult ReadData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public override RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public override RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, Byte[] data_buf, uint data_len) { }

	public override RailResult ResolveHostname(string domain, List<String> ip_list) { }

	public override RailResult SendData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public override RailResult SendData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public override RailResult SendRawData(RailID local_peer, RailGamePeer remote_game_peer, Byte[] data_buf, uint data_len, bool reliable, uint message_type) { }

	public override RailResult SendReliableData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public override RailResult SendReliableData(RailID local_peer, RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public override RailResult UnblockMessageType(RailID local_peer, uint message_type) { }

}

