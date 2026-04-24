namespace ZenFulcrum.EmbeddedBrowser;

public static class ErrorGenerator
{
	private const string htmlIntro = "<!DOCTYPE html><html><head><meta charset="UTF-8">
<style type='text/css'>
	body { background: rgba(255, 255, 255, .7); color: black; }
	#loadError .detail { font-size: 90%; color: #444; }
</style></head><body>
"; //Field offset: 0x0
	private const string htmlOutro = "</body></html>"; //Field offset: 0x0
	private const string loadTemplate = "<div id='loadError'>
	<h1>Load Error</h1>
	<p class='mainError'>{mainError}</p>
	<p class='detail'>{detail}</p>
</div>"; //Field offset: 0x0
	private const string sadTemplate = "<div id='sadTab'>
	<h1>Page Crashed</h1>
	<p>The renderer process for this page is no longer running.</p>
</div>"; //Field offset: 0x0

	private static string Encode(string text) { }

	public static string GenerateCertError(JSONNode err) { }

	public static string GenerateFetchError(JSONNode err) { }

	public static string GenerateSadTabError() { }

}

