namespace Spine;

public class Atlas : IEnumerable<AtlasRegion>, IEnumerable
{
	private readonly List<AtlasPage> pages; //Field offset: 0x10
	private List<AtlasRegion> regions; //Field offset: 0x18
	private TextureLoader textureLoader; //Field offset: 0x20

	public List<AtlasPage> Pages
	{
		 get { } //Length: 5
	}

	public List<AtlasRegion> Regions
	{
		 get { } //Length: 5
	}

	public Atlas(TextReader reader, string dir, TextureLoader textureLoader) { }

	public Atlas(List<AtlasPage> pages, List<AtlasRegion> regions) { }

	public void Dispose() { }

	public AtlasRegion FindRegion(string name) { }

	public void FlipV() { }

	public List<AtlasPage> get_Pages() { }

	public List<AtlasRegion> get_Regions() { }

	public override IEnumerator<AtlasRegion> GetEnumerator() { }

	private void Load(TextReader reader, string imagesDir, TextureLoader textureLoader) { }

	private static int ReadTuple(TextReader reader, String[] tuple) { }

	private static string ReadValue(TextReader reader) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

