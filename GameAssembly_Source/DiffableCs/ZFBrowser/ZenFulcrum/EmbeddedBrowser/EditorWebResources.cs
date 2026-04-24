namespace ZenFulcrum.EmbeddedBrowser;

internal class EditorWebResources : WebResources
{
	protected string basePath; //Field offset: 0x10
	private readonly Regex matchDots; //Field offset: 0x18

	public EditorWebResources() { }

	public virtual void HandleRequest(int id, string url) { }

}

