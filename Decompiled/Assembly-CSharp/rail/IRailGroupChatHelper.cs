using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F4")]
public interface IRailGroupChatHelper
{
	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncQueryGroupsInfo(string user_data);

	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailGroupChat AsyncOpenGroupChat(string group_id, string user_data);
}
