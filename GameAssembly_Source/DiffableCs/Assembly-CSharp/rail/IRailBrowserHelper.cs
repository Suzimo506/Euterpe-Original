namespace rail;

public interface IRailBrowserHelper
{

	public IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options, out RailResult result) { }

	public IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options) { }

	public IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data) { }

	public IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options, out RailResult result) { }

	public IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options) { }

	public IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data) { }

	public RailResult NavigateWebPage(string url, bool display_in_new_tab) { }

}

