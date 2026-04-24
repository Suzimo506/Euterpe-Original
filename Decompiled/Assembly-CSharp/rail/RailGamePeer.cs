using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200032F")]
public class RailGamePeer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400129A")]
	public RailID peer;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400129B")]
	public RailGameID game_id;

	[Token(Token = "0x6002E35")]
	[Address(RVA = "0x27205C0", Offset = "0x271EDC0", Length = "0xFE")]
	public RailGamePeer()
	{
	}
}
