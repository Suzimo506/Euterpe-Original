namespace System.Resources;

internal class FileBasedResourceGroveler : IResourceGroveler
{
	private ResourceManagerMediator _mediator; //Field offset: 0x10

	public FileBasedResourceGroveler(ResourceManagerMediator mediator) { }

	private ResourceSet CreateResourceSet(string file) { }

	private string FindResourceFile(CultureInfo culture, string fileName) { }

	public override ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<String, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

}

