using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000794")]
public class BOSSInfo : BaseDataObject
{
	[Token(Token = "0x400281B")]
	[FieldOffset(Offset = "0x20")]
	public string boss_name;

	[Token(Token = "0x400281C")]
	[FieldOffset(Offset = "0x28")]
	public string scene_name;

	[Token(Token = "0x400281D")]
	[FieldOffset(Offset = "0x30")]
	public string fever;

	[Token(Token = "0x60046C6")]
	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	public BOSSInfo()
	{
	}
}
