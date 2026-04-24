namespace ZenFulcrum.EmbeddedBrowser;

public class StandaloneWebResources : WebResources
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IndexEntry entry; //Field offset: 0x10
		public StandaloneWebResources <>4__this; //Field offset: 0x28
		public int id; //Field offset: 0x30

		public <>c__DisplayClass7_0() { }

		internal void <HandleRequest>b__0() { }

	}

	internal struct IndexEntry
	{
		public string name; //Field offset: 0x0
		public long offset; //Field offset: 0x8
		public int length; //Field offset: 0x10

	}

	private const string FileHeader = "zfbRes_v1"; //Field offset: 0x0
	public const string DefaultPath = "Resources/browser_assets"; //Field offset: 0x0
	protected Dictionary<String, IndexEntry> toc; //Field offset: 0x10
	protected string dataFile; //Field offset: 0x18

	public StandaloneWebResources(string dataFile) { }

	public virtual void HandleRequest(int id, string url) { }

	public void LoadIndex() { }

	public void WriteData(Dictionary<String, Byte[]> files) { }

}

