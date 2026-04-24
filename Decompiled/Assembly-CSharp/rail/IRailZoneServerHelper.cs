using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003EF")]
public interface IRailZoneServerHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FCC")]
	RailZoneID GetPlayerSelectedZoneID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FCD")]
	RailZoneID GetRootZoneID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FCE")]
	IRailZoneServer OpenZoneServer(RailZoneID zone_id, out RailResult result);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FCF")]
	RailResult AsyncSwitchPlayerSelectedZone(RailZoneID zone_id);
}
