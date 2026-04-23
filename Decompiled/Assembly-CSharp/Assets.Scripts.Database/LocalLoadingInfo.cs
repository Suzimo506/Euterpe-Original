using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007DA")]
public class LocalLoadingInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400294D")]
	public string chipName;

	[Token(Token = "0x400294E")]
	[FieldOffset(Offset = "0x28")]
	public string chipDescription;

	[Token(Token = "0x400294F")]
	[FieldOffset(Offset = "0x30")]
	public string nsChipDescription;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002950")]
	public string artist1;

	[Token(Token = "0x4002951")]
	[FieldOffset(Offset = "0x40")]
	public string artist2;

	[Token(Token = "0x4002952")]
	[FieldOffset(Offset = "0x48")]
	public string artist3;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002953")]
	public string homepage1;

	[Token(Token = "0x4002954")]
	[FieldOffset(Offset = "0x58")]
	public string homepage2;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002955")]
	public string homepage3;

	[Token(Token = "0x60047E9")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalLoadingInfo()
	{
	}
}
