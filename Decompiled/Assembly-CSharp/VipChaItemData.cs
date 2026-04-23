using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x200010D")]
public class VipChaItemData : VipItemData
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400069A")]
	public CharacterInfo characterInfo;

	[Address(RVA = "0x4ECC60", Offset = "0x4EB460", Length = "0x31")]
	[Token(Token = "0x60007D1")]
	public VipChaItemData(DBConfigAlbums.AlbumsInfo targetAlbumInfo, CharacterInfo tempCharacterInfo)
		: base(null)
	{
	}
}
