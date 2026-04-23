using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000331")]
public interface IRailPlayer
{
	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool AlreadyLoggedIn();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E38")]
	RailID GetRailID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E39")]
	RailResult GetPlayerDataPath(out string path);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E3A")]
	RailResult AsyncAcquireSessionTicket(string user_data);

	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data);

	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void TerminateSessionOfPlayer(RailID player_rail_id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E3D")]
	void AbandonSessionTicket(RailSessionTicket session_ticket);

	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetPlayerName(out string name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E3F")]
	EnumRailPlayerOwnershipType GetPlayerOwnershipType();

	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetGamePurchaseKey(string user_data);

	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsGameRevenueLimited();

	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x0", Length = "0x0")]
	float GetRateOfGameRevenue();

	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryPlayerBannedStatus(string user_data);

	[Token(Token = "0x6002E44")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetAuthenticateURL(RailGetAuthenticateURLOptions options, string user_data);

	[Token(Token = "0x6002E45")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetPlayerMetadata(List<string> keys, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E46")]
	RailResult AsyncGetEncryptedGameTicket(string set_metadata, string user_data);
}
