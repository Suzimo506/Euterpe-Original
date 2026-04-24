namespace rail;

public class IRailBrowserHelperImpl : RailObject, IRailBrowserHelper
{

	internal IRailBrowserHelperImpl(IntPtr cPtr) { }

	public override IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options, out RailResult result) { }

	public override IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options) { }

	public override IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data) { }

	public override IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options, out RailResult result) { }

	public override IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options) { }

	public override IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data) { }

	protected virtual void Finalize() { }

	public override RailResult NavigateWebPage(string url, bool display_in_new_tab) { }

}

