using Cpp2ILInjected;

namespace UI.Panels.PnlHotfix;

[Token(Token = "0x20001CE")]
internal enum HotfixProgress
{
	[Token(Token = "0x4000B83")]
	catalog_check,
	[Token(Token = "0x4000B84")]
	catalog_update,
	[Token(Token = "0x4000B85")]
	download_force,
	[Token(Token = "0x4000B86")]
	finish
}
