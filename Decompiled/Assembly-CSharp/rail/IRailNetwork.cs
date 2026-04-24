using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200032A")]
public interface IRailNetwork
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E1E")]
	RailResult AcceptSessionRequest(RailID local_peer, RailID remote_peer);

	[Token(Token = "0x6002E1F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SendData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E20")]
	RailResult SendData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E21")]
	RailResult SendReliableData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[Token(Token = "0x6002E22")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SendReliableData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E23")]
	bool IsDataReady(RailID local_peer, out uint data_len, out uint message_type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E24")]
	bool IsDataReady(RailID local_peer, out uint data_len);

	[Token(Token = "0x6002E25")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ReadData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[Token(Token = "0x6002E26")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ReadData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len);

	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult BlockMessageType(RailID local_peer, uint message_type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E28")]
	RailResult UnblockMessageType(RailID local_peer, uint message_type);

	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult CloseSession(RailID local_peer, RailID remote_peer);

	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ResolveHostname(string domain, List<string> ip_list);

	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetSessionState(RailID remote_peer, RailNetworkSessionState session_state);

	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ForbidSessionRelay(bool forbid_relay);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E2D")]
	RailResult SendRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len, bool reliable, uint message_type);

	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AcceptRawSessionRequest(RailID local_peer, RailGamePeer remote_game_peer);

	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len, uint message_type);

	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len);
}
