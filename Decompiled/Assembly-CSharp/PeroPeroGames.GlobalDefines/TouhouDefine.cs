using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200052D")]
public struct TouhouDefine
{
	[Token(Token = "0x4001EB7")]
	public const string touhou_music = "touhou_music";

	[Token(Token = "0x4001EB8")]
	public const string touhou_hp = "touhou_hp";

	[Token(Token = "0x4001EB9")]
	public const string touhou_point = "touhou_point";

	[Token(Token = "0x4001EBA")]
	public const string touhou_p = "touhou_p";

	[Token(Token = "0x4001EBB")]
	public const string touhou_black_suffix = "_touhou_black";

	[Token(Token = "0x4001EBC")]
	public const int touhou_music_fever_add = 1;

	[Token(Token = "0x4001EBD")]
	public const int touhou_hp_fever_add = 10;

	[Token(Token = "0x4001EBE")]
	public const int touhou_point_fever_add = 0;

	[Token(Token = "0x4001EBF")]
	public const int touhou_p_fever_add = 2;

	[Token(Token = "0x4001EC0")]
	public const int touhou_block_fever_add = 1;

	[Token(Token = "0x4001EC1")]
	public const int touhou_big_fever_add = 2;

	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x759D0", Offset = "0x74DD0")]
	[Token(Token = "0x4001EC2")]
	public static readonly decimal touhou_convert_time;

	[Token(Token = "0x4001EC3")]
	public const int touhou_point_score = 400;

	[Token(Token = "0x4001EC4")]
	public const int touhou_p_score = 100;

	[Token(Token = "0x4001EC5")]
	private static uint[] TOUHOU_FEVER_BOOM;

	[Address(RVA = "0x507E70", Offset = "0x506670", Length = "0xA0")]
	[Token(Token = "0x600373A")]
	public static bool IsTouhouFeverBoom(uint type)
	{
		return default(bool);
	}
}
