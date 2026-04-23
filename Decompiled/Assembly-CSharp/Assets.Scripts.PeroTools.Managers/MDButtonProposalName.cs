using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000649")]
public struct MDButtonProposalName
{
	[Token(Token = "0x4002353")]
	public const string Custom = "Custom";

	[Token(Token = "0x4002354")]
	public const string Default = "Default";

	[Token(Token = "0x4002355")]
	public const string DefaultReverse = "DefaultReverse";

	[Token(Token = "0x4002356")]
	public const string ModeB = "ModeB";

	[Token(Token = "0x4002357")]
	public const string ModeBReverse = "ModeBReverse";

	[Token(Token = "0x4002358")]
	public const string ModeC = "ModeC";

	[Token(Token = "0x4002359")]
	public const string ModeCReverse = "ModeCReverse";

	[Token(Token = "0x400235A")]
	public const string ModeD = "ModeD";

	[Token(Token = "0x400235B")]
	public const string ModeDReverse = "ModeDReverse";

	[Token(Token = "0x400235C")]
	public const string ArcadeModeA = "ArcadeA";

	[Token(Token = "0x400235D")]
	public const string ArcadeModeAReverse = "ArcadeAReverse";

	[Token(Token = "0x400235E")]
	public const string ArcadeModeB = "ArcadeB";

	[Token(Token = "0x400235F")]
	public const string ArcadeModeBReverse = "ArcadeBReverse";
}
