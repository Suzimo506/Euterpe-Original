namespace rail;

public class IRailBrowserImpl : RailObject, IRailBrowser, IRailComponent
{

	internal IRailBrowserImpl(IntPtr cPtr) { }

	public override bool AddJavascriptEventListener(string event_name) { }

	public override void AllowNavigateNewPage(bool allow) { }

	public override void Close() { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override bool GetCurrentUrl(out string url) { }

	public override void Release() { }

	public override bool ReloadWithUrl(string new_url) { }

	public override bool ReloadWithUrl() { }

	public override bool RemoveAllJavascriptEventListener() { }

	public override void StopLoad() { }

}

