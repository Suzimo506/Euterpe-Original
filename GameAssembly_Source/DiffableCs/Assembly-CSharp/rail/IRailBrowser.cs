namespace rail;

public interface IRailBrowser : IRailComponent
{

	public bool AddJavascriptEventListener(string event_name) { }

	public void AllowNavigateNewPage(bool allow) { }

	public void Close() { }

	public bool GetCurrentUrl(out string url) { }

	public bool ReloadWithUrl(string new_url) { }

	public bool ReloadWithUrl() { }

	public bool RemoveAllJavascriptEventListener() { }

	public void StopLoad() { }

}

