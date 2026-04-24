using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007AA")]
public class CollabBundle : BaseDataObject
{
	[Token(Token = "0x4002892")]
	[FieldOffset(Offset = "0x20")]
	public string ipUid;

	[Token(Token = "0x4002893")]
	[FieldOffset(Offset = "0x28")]
	public List<string> packagesInIP;

	[Token(Token = "0x6004717")]
	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	public CollabBundle()
	{
	}
}
