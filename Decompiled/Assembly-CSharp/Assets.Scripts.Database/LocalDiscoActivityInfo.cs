using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B6")]
public class LocalDiscoActivityInfo : BaseDataObject
{
	[Token(Token = "0x40028AE")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x600474D")]
	public LocalDiscoActivityInfo()
	{
	}
}
