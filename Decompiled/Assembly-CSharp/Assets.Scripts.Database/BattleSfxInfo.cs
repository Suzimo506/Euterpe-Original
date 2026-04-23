using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000797")]
public class BattleSfxInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002820")]
	public string battleSfxName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002821")]
	public string clip;

	[Token(Token = "0x4002822")]
	[FieldOffset(Offset = "0x30")]
	public string musicPackageUid;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002823")]
	public bool free;

	[Token(Token = "0x4002824")]
	[FieldOffset(Offset = "0x39")]
	public bool hide;

	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4002825")]
	public bool hexie;

	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4002826")]
	public bool exchange;

	[Token(Token = "0x60046CE")]
	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	public BattleSfxInfo()
	{
	}
}
