using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x200052F")]
public struct BMS_TONE_DEFINES
{
	[Token(Token = "0x4001F05")]
	public const string AIR_NORMAL_NOTE_TONE = "13";

	[Token(Token = "0x4001F06")]
	public const string AIR_NORMAL_NOTE_2_TONE = "11";

	[Token(Token = "0x4001F07")]
	public const string GROUND_NORMAL_NOTE_TONE = "14";

	[Token(Token = "0x4001F08")]
	public const string GROUND_NORMAL_NOTE_2_TONE = "12";

	[Token(Token = "0x4001F09")]
	public const string BOSS_ACTION_NOTE_1_TONE = "15";

	[Token(Token = "0x4001F0A")]
	public const string BOSS_ACTION_NOTE_2_TONE = "18";

	[Token(Token = "0x4001F0B")]
	public const string LAYER_DISPLAY_TONE = "LD";

	[Token(Token = "0x4001F0C")]
	public const string AIR_BLOOD_NOTE_TONE = "33";

	[Token(Token = "0x4001F0D")]
	public const string AIR_BLOOD_NOTE_2_TONE = "31";

	[Token(Token = "0x4001F0E")]
	public const string GROUND_BLOOD_NOTE_TONE = "34";

	[Token(Token = "0x4001F0F")]
	public const string GROUND_BLOOD_NOTE_2_TONE = "32";

	[Token(Token = "0x4001F10")]
	public const string AIR_LENGTH_NOTE_TONE = "53";

	[Token(Token = "0x4001F11")]
	public const string AIR_LENGTH_NOTE_2_TONE = "51";

	[Token(Token = "0x4001F12")]
	public const string GROUND_LENGTH_NOTE_TONE = "54";

	[Token(Token = "0x4001F13")]
	public const string GROUND_LENGTH_NOTE_2_TONE = "52";

	[Token(Token = "0x4001F14")]
	public const string SCENE_EVENT_TONE = "01";

	[Token(Token = "0x4001F15")]
	public const string BEAT_PERCENT_TONE = "02";

	[Token(Token = "0x4001F16")]
	public const string BPM_TONE = "03";

	[Token(Token = "0x4001F17")]
	public const string BPM_FLOAT_TONE = "08";
}
