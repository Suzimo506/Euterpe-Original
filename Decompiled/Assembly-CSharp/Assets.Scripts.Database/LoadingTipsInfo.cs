using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007DE")]
public class LoadingTipsInfo : BaseDataObject
{
	[Token(Token = "0x4002959")]
	[FieldOffset(Offset = "0x20")]
	public string tip;

	[Token(Token = "0x60047FB")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LoadingTipsInfo()
	{
	}
}
