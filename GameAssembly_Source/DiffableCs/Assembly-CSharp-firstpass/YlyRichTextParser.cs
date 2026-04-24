//Type is in global namespace

internal class YlyRichTextParser
{
	public const int RICHTEXT_MULL_BASE = 100; //Field offset: 0x0
	private static Int32[] _mask; //Field offset: 0x0
	public const int ANIM_EMOTE_IDX_END = 999; //Field offset: 0x0
	public const int ANIM_EMOTE_IDX_BEGIN = 500; //Field offset: 0x0
	public const int EMOTE_IDX_END = 499; //Field offset: 0x0
	public const int EMOTE_IDX_BEGIN = 1; //Field offset: 0x0
	public const int FIXED_LEN_COLOR_MORPH_BLOCK = 24; //Field offset: 0x0
	public const int FIXED_LEN_COLOR_BLOCK = 16; //Field offset: 0x0
	public const int RICHTEXT_UNKNOWN = -9999; //Field offset: 0x0
	public const int RICHTEXT_DELETE_LINE_END = 21400; //Field offset: 0x0
	public const int RICHTEXT_DELETE_LINE_BASE = 21300; //Field offset: 0x0
	public const int RICHTEXT_SIZE_END = 21200; //Field offset: 0x0
	public const int RICHTEXT_SIZE_BASE = 21100; //Field offset: 0x0
	public const int RICHTEXT_ITALIC_BASE = 20900; //Field offset: 0x0
	public const int RICHTEXT_ITALIC_END = 21000; //Field offset: 0x0
	public const int RICHTEXT_BOLD_BASE = 20700; //Field offset: 0x0
	public const int RICHTEXT_UNDER_LINE_END = 20600; //Field offset: 0x0
	public const int RICHTEXT_ENTER = 20500; //Field offset: 0x0
	public const int RICHTEXT_COLOR_END = 20400; //Field offset: 0x0
	public const int RICHTEXT_LINK_END = 20300; //Field offset: 0x0
	public const int RICHTEXT_UNDER_LINE_BASE = 20200; //Field offset: 0x0
	public const int RICHTEXT_LINK_BASE = 20100; //Field offset: 0x0
	public const int RICHTEXT_COLOR_BASE = 20000; //Field offset: 0x0
	public const int RICHTEXT_CICON_BASE = 10300; //Field offset: 0x0
	public const int RICHTEXT_RES_PATH_BASE = 10200; //Field offset: 0x0
	public const int RICHTEXT_ANIM_EMOTE_BASE = 10100; //Field offset: 0x0
	public const int RICHTEXT_EMOTE_BASE = 10000; //Field offset: 0x0
	public const int RICHTEXT_BOLD_END = 20800; //Field offset: 0x0
	private static Dictionary<Int32, String> _parms; //Field offset: 0x8
	private static Dictionary<String, Int32> _preLoadAsset; //Field offset: 0x10
	private static StringBuilder _logStr; //Field offset: 0x18

	private static YlyRichTextParser() { }

	public YlyRichTextParser() { }

	public static int GetEmoteType(int idx) { }

	public static string GetLog() { }

	public static bool IsPunctuation(char str) { }

	public static string Parse(string str, out Int32[] mask, out Dictionary<Int32, String>& param, out Dictionary<String, Int32>& preLoadAsset, bool enableRichText) { }

	private static void ParseSingle(string str, string rex, int ibase) { }

}

