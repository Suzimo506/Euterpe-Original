using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000285")]
public interface IRailBrowserHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC7")]
	IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options, out RailResult result);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CC8")]
	IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options);

	[Token(Token = "0x6002CC9")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data);

	[Token(Token = "0x6002CCA")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options, out RailResult result);

	[Token(Token = "0x6002CCB")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options);

	[Token(Token = "0x6002CCC")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data);

	[Token(Token = "0x6002CCD")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult NavigateWebPage(string url, bool display_in_new_tab);
}
