using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C4")]
public class LocalElfinInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002900")]
	public string name;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002901")]
	public List<ElfinSkin> skins;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002902")]
	public string description;

	[Token(Token = "0x4002903")]
	[FieldOffset(Offset = "0x38")]
	public string skill;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002904")]
	public string chipName;

	[Token(Token = "0x4002905")]
	[FieldOffset(Offset = "0x48")]
	public string chipDescription;

	[Token(Token = "0x6004797")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalElfinInfo()
	{
	}
}
