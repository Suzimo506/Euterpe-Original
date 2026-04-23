using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007BD")]
public class LocalDlcBillboardInfo : BaseDataObject
{
	[Token(Token = "0x40028CB")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x40028CC")]
	[FieldOffset(Offset = "0x28")]
	public string description2;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40028CD")]
	public string soundDescription;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40028CE")]
	public List<List<string>> expressions;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x6004768")]
	public LocalDlcBillboardInfo()
	{
	}
}
