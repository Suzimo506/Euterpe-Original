using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x20004FD")]
public struct AnimatorDefines
{
	[Token(Token = "0x4001B2E")]
	public const string anim_in = "in";

	[Token(Token = "0x4001B2F")]
	public const string anim_out = "out";

	[Token(Token = "0x4001B30")]
	private static int animInHash;

	[Token(Token = "0x4001B31")]
	private static int animOutHash;

	[Token(Token = "0x17000503")]
	public static int anim_in_hash
	{
		[Address(RVA = "0x4EE620", Offset = "0x4ECE20", Length = "0x55")]
		[Token(Token = "0x6003716")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000504")]
	public static int anim_out_hash
	{
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x4EE680", Offset = "0x4ECE80", Length = "0x56")]
		get
		{
			return default(int);
		}
	}
}
