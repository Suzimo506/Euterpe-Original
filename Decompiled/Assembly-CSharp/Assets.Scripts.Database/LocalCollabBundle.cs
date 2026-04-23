using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A8")]
public class LocalCollabBundle : BaseDataObject
{
	[Token(Token = "0x4002890")]
	[FieldOffset(Offset = "0x20")]
	public string ipName;

	[Token(Token = "0x6004711")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalCollabBundle()
	{
	}
}
