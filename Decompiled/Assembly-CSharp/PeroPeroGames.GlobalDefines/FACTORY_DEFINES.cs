using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000513")]
public struct FACTORY_DEFINES
{
	[Token(Token = "0x4001CA3")]
	public static readonly Type[] CONTROLLERS;

	[Token(Token = "0x4001CA4")]
	public static readonly Type[] DONOTINGS;

	[Token(Token = "0x4001CA5")]
	public static readonly Type[] MULTI_DONOTINGS;
}
