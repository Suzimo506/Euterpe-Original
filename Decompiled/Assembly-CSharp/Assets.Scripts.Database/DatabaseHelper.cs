using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200081A")]
public struct DatabaseHelper
{
	[Token(Token = "0x4002A50")]
	private static DateTime m_ChangeTime;

	[Address(RVA = "0x103C3E0", Offset = "0x103ABE0", Length = "0x24")]
	[Token(Token = "0x6004ACC")]
	public static int GetUnlockDiffByAbility(float ability)
	{
		return default(int);
	}

	[Token(Token = "0x6004ACD")]
	[Address(RVA = "0x103C600", Offset = "0x103AE00", Length = "0x2E2")]
	private static void SetAbility(float value)
	{
	}

	[Token(Token = "0x6004ACE")]
	[Address(RVA = "0x103C410", Offset = "0x103AC10", Length = "0x1E7")]
	public static void InitAbilityLogic()
	{
	}
}
