using System;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;

namespace DaveGameFramework.GameActivedObjects;

[Token(Token = "0x20004DA")]
public class DaveGameNoteCreateFactory
{
	[Token(Token = "0x6003616")]
	[Address(RVA = "0x46F0A0", Offset = "0x46D8A0", Length = "0xCC")]
	public static Type GetNoteType(BmsNodeUid nodeUid)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003617")]
	public DaveGameNoteCreateFactory()
	{
	}
}
