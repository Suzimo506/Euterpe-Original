using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x20004F7")]
public struct DataStatisticsEventDefines
{
	[Token(Token = "0x4001AF9")]
	public const string device_first_active = "device_active";

	[Token(Token = "0x4001AFA")]
	public const string begin_purchase = "order_init";

	[Token(Token = "0x4001AFB")]
	public const string purchased = "payment";

	[Token(Token = "0x4001AFC")]
	public const string purchase_failed = "payment_fail";

	[Token(Token = "0x4001AFD")]
	public const string steam_payment_activate = "steam_payment_activate";

	[Token(Token = "0x4001AFE")]
	public const string wegame_payment_activate = "wegame_payment_activate";

	[Token(Token = "0x4001AFF")]
	public const string updatable_driver_offset = "updatable_driver_offset";

	[Token(Token = "0x4001B00")]
	public const string app_online_time = "app_online_time";

	[Token(Token = "0x4001B01")]
	public const string products_taptap = "products_taptap";

	[Token(Token = "0x4001B02")]
	public const string products_ios = "products_ios";

	[Token(Token = "0x4001B03")]
	public const string products_google = "products_google";

	[Token(Token = "0x4001B04")]
	public const string products_wegame = "products_wegame";

	[Token(Token = "0x4001B05")]
	public const string products_steam = "products_steam";

	[Token(Token = "0x4001B06")]
	public const string match_abandon = "match_abandon";

	[Token(Token = "0x4001B07")]
	public const string play_event = "play_event";

	[Token(Token = "0x4001B08")]
	public const string match_failure = "match_failure";

	[Token(Token = "0x4001B09")]
	public const string favorite_music = "favorite_music";

	[Token(Token = "0x4001B0A")]
	public const string cancel_favorite_music = "cancel_favorite_music";

	[Token(Token = "0x4001B0B")]
	public const string hide_music = "hide_music";

	[Token(Token = "0x4001B0C")]
	public const string new_player_guide = "new_player_guide";

	[Token(Token = "0x4001B0D")]
	public const string enter_shop = "enter_shop";

	[Token(Token = "0x4001B0E")]
	public const string enter_shop_muse_plus = "enter_shop_muse_plus";

	[Token(Token = "0x4001B0F")]
	public const string shop_check_page = "shop_check_page";

	[Token(Token = "0x4001B10")]
	public const string store_to_ways = "store_to_ways";

	[Token(Token = "0x4001B11")]
	public const string store_product_name = "store_product_name";

	[Token(Token = "0x4001B12")]
	public const string trouble_support_info = "trouble_support_info";

	[Token(Token = "0x4001B13")]
	public const string achievement_data = "achievement_data";

	[Token(Token = "0x4001B14")]
	public const string driver_offset_evevt = "driver_offset_evevt";

	[Token(Token = "0x4001B15")]
	public static string ability_advanced;

	[Token(Token = "0x4001B16")]
	public static string theme_bg_preview;

	[Token(Token = "0x4001B17")]
	public static string theme_bg_wear;

	[Token(Token = "0x4001B18")]
	public const string add_favorite_character = "add_favorite_character";

	[Token(Token = "0x4001B19")]
	public const string cancel_favorite_character = "cancel_favorite_character";

	[Token(Token = "0x4001B1A")]
	public const string open_music_search_panel = "open_music_search_panel";

	[Token(Token = "0x4001B1B")]
	public const string music_tag_search = "music_tag_search";

	[Token(Token = "0x4001B1C")]
	public const string difficulty_filtrate = "difficulty_filtrate";

	[Token(Token = "0x4001B1D")]
	public const string music_search = "music_search";

	[Token(Token = "0x4001B1E")]
	public const string music_choose = "music_choose";

	[Token(Token = "0x4001B1F")]
	public const string skin_preview = "skin_preview";

	[Token(Token = "0x4001B20")]
	public const string skin_wear = "skin_wear";

	[Token(Token = "0x4001B21")]
	public const string account_login = "account_login";

	[Token(Token = "0x4001B22")]
	public const string account_logout = "account_logout";

	[Token(Token = "0x4001B23")]
	public const string user_create = "user_create";

	[Token(Token = "0x4001B24")]
	public const string user_cancel = "user_cancel";

	[Token(Token = "0x4001B25")]
	public const string user_online = "user_online";
}
