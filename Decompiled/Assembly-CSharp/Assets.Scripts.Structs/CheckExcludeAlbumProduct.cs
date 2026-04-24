using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000579")]
internal struct CheckExcludeAlbumProduct
{
	[Token(Token = "0x400204A")]
	[FieldOffset(Offset = "0x0")]
	public string purchaseId;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400204B")]
	public string lockalbumId;

	[Token(Token = "0x600386B")]
	[Address(RVA = "0x52B410", Offset = "0x529C10", Length = "0x31")]
	public CheckExcludeAlbumProduct(string purchaseId, string lockalbumId)
	{
	}
}
