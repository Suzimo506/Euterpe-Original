using System.Collections.Generic;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004EC")]
public static class MDPlayerProperty
{
	[Token(Token = "0x4001A9A")]
	public static string music_name;

	[Token(Token = "0x4001A9B")]
	public static string music_uid;

	[Token(Token = "0x4001A9C")]
	public static string album_name;

	[Token(Token = "0x4001A9D")]
	public static string album_uid;

	[Token(Token = "0x4001A9E")]
	public static string music_difficulty_factor;

	[Token(Token = "0x4001A9F")]
	public static string play_level_type;

	[Token(Token = "0x4001AA0")]
	public static bool is_networking;

	[Token(Token = "0x4001AA1")]
	public static string role_name;

	[Token(Token = "0x4001AA2")]
	public static string pet_name;

	[Token(Token = "0x4001AA3")]
	public static float note_accuracy;

	[Token(Token = "0x4001AA4")]
	public static int max_combo;

	[Token(Token = "0x4001AA5")]
	public static string failure_time;

	[Token(Token = "0x4001AA6")]
	public static string abandonment_reason;

	[Token(Token = "0x4001AA7")]
	public static string play_source;

	[Token(Token = "0x4001AA8")]
	public static bool music_is_weekly;

	[Token(Token = "0x4001AA9")]
	public static List<string> per_note_accuracy;

	[Token(Token = "0x4001AAA")]
	public static Dictionary<string, object> pushList;
}
