using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000512")]
public struct MusicTagsDefine
{
	[Token(Token = "0x4001C87")]
	public const int collection = 0;

	[Token(Token = "0x4001C88")]
	public const int all = 1;

	[Token(Token = "0x4001C89")]
	public const int base_album = 2;

	[Token(Token = "0x4001C8A")]
	public const int cute = 3;

	[Token(Token = "0x4001C8B")]
	public const int happy = 4;

	[Token(Token = "0x4001C8C")]
	public const int give_up = 5;

	[Token(Token = "0x4001C8D")]
	public const int theme = 6;

	[Token(Token = "0x4001C8E")]
	public const int other = 7;

	[Token(Token = "0x4001C8F")]
	public const int hide = 8;

	[Token(Token = "0x4001C90")]
	public const int new_album = 9;

	[Token(Token = "0x4001C91")]
	public const int plan = 10;

	[Token(Token = "0x4001C92")]
	public const int history = 11;

	[Token(Token = "0x4001C93")]
	public const int music_tags_count = 12;

	[Token(Token = "0x4001C94")]
	public const int custom_tag_start = 32768;

	[Token(Token = "0x4001C95")]
	public const string tag_collections = "collections";

	[Token(Token = "0x4001C96")]
	public const string tag_all = "tag-1";

	[Token(Token = "0x4001C97")]
	public const string tag_base_album = "tag-2";

	[Token(Token = "0x4001C98")]
	public const string tag_give_up = "tag-3";

	[Token(Token = "0x4001C99")]
	public const string tag_happy = "tag-4";

	[Token(Token = "0x4001C9A")]
	public const string tag_cute = "tag-5";

	[Token(Token = "0x4001C9B")]
	public const string tag_theme = "tag-6";

	[Token(Token = "0x4001C9C")]
	public const string tag_other = "tag-7";

	[Token(Token = "0x4001C9D")]
	public const string tag_plan = "tag-8";

	[Token(Token = "0x4001C9E")]
	public const string tag_hide = "hide";

	[Token(Token = "0x4001C9F")]
	public const string tag_new_album = "tag-news";

	[Token(Token = "0x4001CA0")]
	public const string tag_history = "tag-history";

	[Token(Token = "0x4001CA1")]
	public const string tag_hide_map = "tag-hideMap";

	[Token(Token = "0x4001CA2")]
	public const string tag_custom = "tag-custom";
}
