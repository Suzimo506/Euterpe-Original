using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000792")]
internal class AnchorInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002815")]
	public List<AnchorMusicInfo> album_list;

	[Token(Token = "0x4002816")]
	[FieldOffset(Offset = "0x18")]
	public List<AnchorElfinList> elfin_list;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002817")]
	public List<AnchorBanBgmInfo> ban_bgm_list;

	[Token(Token = "0x60046BF")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public AnchorInfo()
	{
	}
}
