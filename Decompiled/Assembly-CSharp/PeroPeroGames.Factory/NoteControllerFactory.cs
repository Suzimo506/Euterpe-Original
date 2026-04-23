using System;
using Cpp2ILInjected;

namespace PeroPeroGames.Factory;

[Token(Token = "0x20004FB")]
public static class NoteControllerFactory
{
	[Address(RVA = "0x4F6B70", Offset = "0x4F5370", Length = "0x1F5")]
	[Token(Token = "0x6003714")]
	public static Type GetControllerType(int actionIndex)
	{
		return null;
	}
}
