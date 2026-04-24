using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000537")]
internal struct UrlDefines
{
	[Token(Token = "0x4001F5D")]
	public const string mobile_feedback_url = "https://prpr-muse-dash.peropero.net/redirect/62538a15c3e6ff64f50be938";

	[Token(Token = "0x4001F5E")]
	public const string pc_feedback_url = "https://prpr-muse-dash.peropero.net/redirect/62538a15c3e6ff64f50be938";

	[Token(Token = "0x4001F5F")]
	public const string find_account_url = "https://prpr-muse-dash.peropero.net/redirect/684a6a320cef47750bd107e0";

	[Token(Token = "0x4001F60")]
	public const string apply_change_account_bind = "https://prpr-muse-dash.peropero.net/redirect/684a6a413bf67cc0a9666296";

	[Token(Token = "0x4001F61")]
	public const string pc_google_login_url = "https://us-musedash.peropero.net/oauth/google/login1";

	[Token(Token = "0x4001F62")]
	public const string pc_facebook_login_url = "https://us-musedash.peropero.net/oauth/facebook/login";
}
