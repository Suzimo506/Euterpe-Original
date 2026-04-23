using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000787")]
public class LocalALBUMInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40027C6")]
	public string name;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40027C7")]
	public string author;

	[Token(Token = "0x6004682")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalALBUMInfo()
	{
	}
}
