namespace UnityEngine.AddressableAssets;

internal class DynamicResourceLocator : IResourceLocator
{
	private AddressablesImpl m_Addressables; //Field offset: 0x10
	private string m_AtlasSpriteProviderId; //Field offset: 0x18

	private string AtlasSpriteProviderId
	{
		private get { } //Length: 574
	}

	public override IEnumerable<Object> Keys
	{
		 get { } //Length: 49
	}

	public override string LocatorId
	{
		 get { } //Length: 43
	}

	public DynamicResourceLocator(AddressablesImpl addr) { }

	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }

	private string get_AtlasSpriteProviderId() { }

	public override IEnumerable<Object> get_Keys() { }

	public override string get_LocatorId() { }

	public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

}

