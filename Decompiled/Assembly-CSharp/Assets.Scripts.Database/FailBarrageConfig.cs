using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C8")]
public class FailBarrageConfig : BaseDataObject
{
	[Token(Token = "0x400290A")]
	[FieldOffset(Offset = "0x20")]
	public int index;

	[Token(Token = "0x400290B")]
	[FieldOffset(Offset = "0x24")]
	public bool silencer;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x60047AB")]
	public FailBarrageConfig()
	{
	}
}
