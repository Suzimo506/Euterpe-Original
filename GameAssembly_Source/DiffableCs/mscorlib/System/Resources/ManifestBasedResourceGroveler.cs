namespace System.Resources;

internal class ManifestBasedResourceGroveler : IResourceGroveler
{
	private ResourceManagerMediator _mediator; //Field offset: 0x10

	public ManifestBasedResourceGroveler(ResourceManagerMediator mediator) { }

	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }

	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	private string GetSatelliteAssemblyName() { }

	public override ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<String, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	private void HandleResourceStreamMissing(string fileName) { }

	private void HandleSatelliteMissing() { }

	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

}

