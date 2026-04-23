using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007CC")]
public class FeverInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400290F")]
	public int feverIndex;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002910")]
	public string feverImage;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002911")]
	public string feverPrefab;

	[Token(Token = "0x4002912")]
	[FieldOffset(Offset = "0x38")]
	public string feverName;

	[Token(Token = "0x4002913")]
	[FieldOffset(Offset = "0x40")]
	public string musicPackageUid;

	[Token(Token = "0x4002914")]
	[FieldOffset(Offset = "0x48")]
	public bool free;

	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4002915")]
	public bool hide;

	[Token(Token = "0x4002916")]
	[FieldOffset(Offset = "0x4A")]
	public bool hexie;

	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x4002917")]
	public bool exchange;

	[Token(Token = "0x60047B7")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public FeverInfo()
	{
	}
}
