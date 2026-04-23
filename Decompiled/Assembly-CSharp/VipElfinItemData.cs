using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x200010E")]
public class VipElfinItemData : VipItemData
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400069B")]
	public ElfinInfo elfinInfo;

	[Address(RVA = "0x746990", Offset = "0x745190", Length = "0x4C")]
	[Token(Token = "0x60007D2")]
	public VipElfinItemData(DBConfigAlbums.AlbumsInfo targetAlbumInfo, ElfinInfo tempElfinInfo)
		: base(null)
	{
	}
}
