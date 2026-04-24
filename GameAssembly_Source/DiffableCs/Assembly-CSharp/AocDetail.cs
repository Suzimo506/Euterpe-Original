//Type is in global namespace

public class AocDetail
{
	private readonly String[] m_FullAssetName; //Field offset: 0x10
	private readonly List<String> m_AssetName; //Field offset: 0x18
	private readonly AssetBundle m_AssetBundle; //Field offset: 0x20

	public AocDetail(AssetBundle ab) { }

	public bool ContainsAsset(string name) { }

	public T GetAsset(string name) { }

	public void UnLoad() { }

}

