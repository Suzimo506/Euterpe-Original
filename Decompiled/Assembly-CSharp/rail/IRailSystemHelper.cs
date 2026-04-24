using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200038C")]
public interface IRailSystemHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EF5")]
	RailResult SetTerminationTimeoutOwnershipExpired(int timeout_seconds);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EF6")]
	RailSystemState GetPlatformSystemState();
}
