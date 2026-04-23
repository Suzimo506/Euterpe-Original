using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007DD")]
public class LocalLoadingTipsInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002958")]
	public string tip;

	[Token(Token = "0x60047FA")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalLoadingTipsInfo()
	{
	}
}
