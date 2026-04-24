using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200026B")]
public interface IRailApps
{
	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsGameInstalled(RailGameID game_id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C99")]
	RailResult AsyncQuerySubscribeWishPlayState(RailGameID game_id, string user_data);
}
