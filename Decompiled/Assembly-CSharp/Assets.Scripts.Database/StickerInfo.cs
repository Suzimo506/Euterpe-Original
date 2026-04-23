using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F6")]
public class StickerInfo : BaseDataObject
{
	[Token(Token = "0x4002997")]
	[FieldOffset(Offset = "0x20")]
	public string image;

	[Token(Token = "0x4002998")]
	[FieldOffset(Offset = "0x28")]
	public StickerGetChannel getChannel;

	[Token(Token = "0x4002999")]
	[FieldOffset(Offset = "0x2C")]
	public StickerAnchor anchor;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400299A")]
	public float offsetY;

	[Token(Token = "0x400299B")]
	[FieldOffset(Offset = "0x34")]
	public float offsetX;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400299C")]
	public string albumUid;

	[Token(Token = "0x600485B")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public StickerInfo()
	{
	}
}
