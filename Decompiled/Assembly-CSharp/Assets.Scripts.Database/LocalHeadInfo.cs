using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D1")]
public class LocalHeadInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002928")]
	public string unlockTip;

	[Token(Token = "0x60047C8")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalHeadInfo()
	{
	}
}
