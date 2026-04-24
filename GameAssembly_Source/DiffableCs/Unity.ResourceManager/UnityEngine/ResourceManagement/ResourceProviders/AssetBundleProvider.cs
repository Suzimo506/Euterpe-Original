namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName]
public class AssetBundleProvider : ResourceProviderBase
{

	public AssetBundleProvider() { }

	public virtual Type GetDefaultType(IResourceLocation location) { }

	public virtual void Provide(ProvideHandle providerInterface) { }

	public virtual void Release(IResourceLocation location, object asset) { }

}

