using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007FD")]
public class UnlockAllInfo : BaseDataObject
{
	[Token(Token = "0x40029A3")]
	[FieldOffset(Offset = "0x20")]
	public string uid;

	[Token(Token = "0x40029A4")]
	[FieldOffset(Offset = "0x28")]
	public decimal discount;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40029A5")]
	public decimal price;

	[Token(Token = "0x40029A6")]
	[FieldOffset(Offset = "0x48")]
	public int displayDiscount;

	[Address(RVA = "0x4ABFC0", Offset = "0x4AA7C0", Length = "0x85")]
	[Token(Token = "0x6004879")]
	public UnlockAllInfo Clone()
	{
		return null;
	}

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x600487A")]
	public UnlockAllInfo()
	{
	}
}
