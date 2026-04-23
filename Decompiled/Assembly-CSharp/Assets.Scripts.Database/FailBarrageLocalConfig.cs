using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C7")]
public class FailBarrageLocalConfig : BaseDataObject
{
	[Token(Token = "0x4002908")]
	[FieldOffset(Offset = "0x20")]
	public int index;

	[Token(Token = "0x4002909")]
	[FieldOffset(Offset = "0x28")]
	public string[] barrages;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x60047AA")]
	public FailBarrageLocalConfig()
	{
	}
}
