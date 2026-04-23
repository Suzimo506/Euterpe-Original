using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002DE")]
public class RailGameDefineGamePlayingState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011DB")]
	public string state_name_zh_cn;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011DC")]
	public string state_name_en_us;

	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x20")]
	public uint game_define_game_playing_state;

	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailGameDefineGamePlayingState()
	{
	}
}
