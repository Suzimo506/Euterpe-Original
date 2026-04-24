using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200057F")]
public struct AchiInfo
{
	[Token(Token = "0x400208F")]
	[FieldOffset(Offset = "0x0")]
	public string uid;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4002090")]
	public string saveUid;

	[Token(Token = "0x4002091")]
	[FieldOffset(Offset = "0x10")]
	public int packageIndex;

	[Token(Token = "0x4002092")]
	[FieldOffset(Offset = "0x14")]
	public int musicIndex;

	[Token(Token = "0x4002093")]
	[FieldOffset(Offset = "0x18")]
	public int achiDiffIndex;

	[Token(Token = "0x4002094")]
	[FieldOffset(Offset = "0x1C")]
	public int achiIndex;

	[Token(Token = "0x6003870")]
	[Address(RVA = "0x653FA0", Offset = "0x6527A0", Length = "0x192")]
	public static bool TryParse(string parseUid, out AchiInfo result)
	{
		System.Runtime.CompilerServices.Unsafe.As<AchiInfo, @null>(ref result) = null;
		return default(bool);
	}

	[Address(RVA = "0x653D70", Offset = "0x652570", Length = "0x228")]
	[Token(Token = "0x6003871")]
	public static bool TryParse(string parseUid, ref AchievementArgs args, out AchiInfo result)
	{
		System.Runtime.CompilerServices.Unsafe.As<AchiInfo, @null>(ref result) = null;
		return default(bool);
	}

	[Address(RVA = "0x653CB0", Offset = "0x6524B0", Length = "0xB5")]
	[Token(Token = "0x6003872")]
	private static string ToStageAchiUid(ref AchievementArgs args, ref AchiInfo achiInfo)
	{
		return null;
	}
}
