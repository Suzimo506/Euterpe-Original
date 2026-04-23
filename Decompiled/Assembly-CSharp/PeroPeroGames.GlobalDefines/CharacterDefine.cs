using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000534")]
public struct CharacterDefine
{
	[Token(Token = "0x4001F2B")]
	public const int rin_rock = 0;

	[Token(Token = "0x4001F2C")]
	public const int rin_rampage = 1;

	[Token(Token = "0x4001F2D")]
	public const int rin_sleepy = 2;

	[Token(Token = "0x4001F2E")]
	public const int rin_bunny = 3;

	[Token(Token = "0x4001F2F")]
	public const int buro_pilot = 4;

	[Token(Token = "0x4001F30")]
	public const int buro_robot = 5;

	[Token(Token = "0x4001F31")]
	public const int buro_zombie = 6;

	[Token(Token = "0x4001F32")]
	public const int buro_joker = 7;

	[Token(Token = "0x4001F33")]
	public const int marija_violin = 8;

	[Token(Token = "0x4001F34")]
	public const int marija_maid = 9;

	[Token(Token = "0x4001F35")]
	public const int marija_magic = 10;

	[Token(Token = "0x4001F36")]
	public const int marija_evil = 11;

	[Token(Token = "0x4001F37")]
	public const int marija_black = 12;

	[Token(Token = "0x4001F38")]
	public const int rin_santa = 13;

	[Token(Token = "0x4001F39")]
	public const int buro_jk = 14;

	[Token(Token = "0x4001F3A")]
	public const int yume = 15;

	[Token(Token = "0x4001F3B")]
	public const int neko = 16;

	[Token(Token = "0x4001F3C")]
	public const int rin_worker = 17;

	[Token(Token = "0x4001F3D")]
	public const int reimu = 18;

	[Token(Token = "0x4001F3E")]
	public const int clear = 19;

	[Token(Token = "0x4001F3F")]
	public const int marija_sister = 20;

	[Token(Token = "0x4001F40")]
	public const int marisa = 21;

	[Token(Token = "0x4001F41")]
	public const int ark_nights_amiya = 22;

	[Token(Token = "0x4001F42")]
	public const int buro_ola = 23;

	[Token(Token = "0x4001F43")]
	public const int buro_taoist = 24;

	[Token(Token = "0x4001F44")]
	public const int hastune_miku = 25;

	[Token(Token = "0x4001F45")]
	public const int kagamine_rin_len = 26;

	[Token(Token = "0x4001F46")]
	public const int rin_racer = 27;

	[Token(Token = "0x4001F47")]
	public const int dancer_marija = 28;

	[Token(Token = "0x4001F48")]
	public const int ark_night_w = 29;

	[Token(Token = "0x4001F49")]
	public const int buro_legend = 30;

	[Token(Token = "0x4001F4A")]
	public const int buro_bloodheir = 31;

	[Token(Token = "0x4001F4B")]
	public const int rin_pirate = 32;

	[Token(Token = "0x4001F4C")]
	public const int buro_diver = 33;

	[Address(RVA = "0x4EEA80", Offset = "0x4ED280", Length = "0xF")]
	[Token(Token = "0x6003748")]
	public static bool IsTouhouRole(int index)
	{
		return default(bool);
	}
}
