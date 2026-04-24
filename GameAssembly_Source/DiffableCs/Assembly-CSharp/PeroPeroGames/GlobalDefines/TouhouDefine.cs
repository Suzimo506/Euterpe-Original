namespace PeroPeroGames.GlobalDefines;

public struct TouhouDefine
{
	public const string touhou_music = "touhou_music"; //Field offset: 0x0
	public const string touhou_hp = "touhou_hp"; //Field offset: 0x0
	public const string touhou_point = "touhou_point"; //Field offset: 0x0
	public const string touhou_p = "touhou_p"; //Field offset: 0x0
	public const string touhou_black_suffix = "_touhou_black"; //Field offset: 0x0
	public const int touhou_music_fever_add = 1; //Field offset: 0x0
	public const int touhou_hp_fever_add = 10; //Field offset: 0x0
	public const int touhou_point_fever_add = 0; //Field offset: 0x0
	public const int touhou_p_fever_add = 2; //Field offset: 0x0
	public const int touhou_block_fever_add = 1; //Field offset: 0x0
	public const int touhou_big_fever_add = 2; //Field offset: 0x0
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal touhou_convert_time; //Field offset: 0x0
	public const int touhou_point_score = 400; //Field offset: 0x0
	public const int touhou_p_score = 100; //Field offset: 0x0
	private static UInt32[] TOUHOU_FEVER_BOOM; //Field offset: 0x10

	private static TouhouDefine() { }

	public static bool IsTouhouFeverBoom(uint type) { }

}

