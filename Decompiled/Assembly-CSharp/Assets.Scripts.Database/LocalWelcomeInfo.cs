using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000803")]
public class LocalWelcomeInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40029BB")]
	public string chipName;

	[Token(Token = "0x40029BC")]
	[FieldOffset(Offset = "0x28")]
	public string chipDescription;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40029BD")]
	public string artist1;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40029BE")]
	public string artist2;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40029BF")]
	public string homepage1;

	[Token(Token = "0x40029C0")]
	[FieldOffset(Offset = "0x48")]
	public string homepage2;

	[Token(Token = "0x6004895")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalWelcomeInfo()
	{
	}
}
