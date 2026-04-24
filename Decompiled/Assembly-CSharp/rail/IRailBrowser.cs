using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000284")]
public interface IRailBrowser : IRailComponent
{
	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetCurrentUrl(out string url);

	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool ReloadWithUrl(string new_url);

	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool ReloadWithUrl();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC2")]
	void StopLoad();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC3")]
	bool AddJavascriptEventListener(string event_name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC4")]
	bool RemoveAllJavascriptEventListener();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC5")]
	void AllowNavigateNewPage(bool allow);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC6")]
	void Close();
}
