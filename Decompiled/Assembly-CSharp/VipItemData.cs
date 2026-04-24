using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x200010C")]
public class VipItemData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000699")]
	public DBConfigAlbums.AlbumsInfo albumInfo;

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x494AC0", Offset = "0x4932C0", Length = "0x30")]
	public VipItemData(DBConfigAlbums.AlbumsInfo targetAlbumInfo)
	{
	}
}
