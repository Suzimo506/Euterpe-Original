namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName]
public class JsonAssetProvider : TextDataProvider
{

	public JsonAssetProvider() { }

	public virtual object Convert(Type type, string text) { }

}

