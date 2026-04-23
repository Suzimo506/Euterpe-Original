using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007CB")]
public class LocalFeverInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400290E")]
	public string feverName;

	[Token(Token = "0x60047B6")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalFeverInfo()
	{
	}
}
