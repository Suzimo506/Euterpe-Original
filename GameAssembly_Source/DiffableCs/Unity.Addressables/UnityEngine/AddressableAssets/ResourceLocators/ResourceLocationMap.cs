namespace UnityEngine.AddressableAssets.ResourceLocators;

public class ResourceLocationMap : IResourceLocator
{
	[CompilerGenerated]
	private string <LocatorId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<Object, IList`1<IResourceLocation>> <Locations>k__BackingField; //Field offset: 0x18

	public override IEnumerable<Object> Keys
	{
		 get { } //Length: 67
	}

	public private Dictionary<Object, IList`1<IResourceLocation>> Locations
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private override string LocatorId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public ResourceLocationMap(string id, int capacity = 0) { }

	public ResourceLocationMap(string id, IList<ResourceLocationData> locations) { }

	public void Add(object key, IResourceLocation location) { }

	public void Add(object key, IList<IResourceLocation> locations) { }

	public override IEnumerable<Object> get_Keys() { }

	[CompilerGenerated]
	public Dictionary<Object, IList`1<IResourceLocation>> get_Locations() { }

	[CompilerGenerated]
	public override string get_LocatorId() { }

	public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

	[CompilerGenerated]
	private void set_Locations(Dictionary<Object, IList`1<IResourceLocation>> value) { }

	[CompilerGenerated]
	private void set_LocatorId(string value) { }

}

