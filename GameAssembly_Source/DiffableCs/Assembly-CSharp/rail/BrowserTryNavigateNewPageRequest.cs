namespace rail;

public class BrowserTryNavigateNewPageRequest : EventBase
{
	public string url; //Field offset: 0x30
	public string target_type; //Field offset: 0x38
	public bool is_redirect_request; //Field offset: 0x40

	public BrowserTryNavigateNewPageRequest() { }

}

