namespace ZenFulcrum.EmbeddedBrowser;

public class BrowserSystemSettings : MonoBehaviour
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string profilePath; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string userAgent; //Field offset: 0x20

	public BrowserSystemSettings() { }

	public void Awake() { }

}

