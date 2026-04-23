using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200026D")]
public interface IRailAssetsHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CAA")]
	IRailAssets OpenAssets();

	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailAssets OpenGameServerAssets();
}
