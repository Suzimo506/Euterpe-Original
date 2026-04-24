using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000796")]
public class LocalBattleSfxInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400281F")]
	public string battleSfxName;

	[Token(Token = "0x60046CD")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalBattleSfxInfo()
	{
	}
}
