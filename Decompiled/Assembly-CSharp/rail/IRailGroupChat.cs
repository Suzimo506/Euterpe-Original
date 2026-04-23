using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F3")]
public interface IRailGroupChat : IRailComponent
{
	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGroupInfo(RailGroupInfo group_info);

	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult OpenGroupWindow();
}
