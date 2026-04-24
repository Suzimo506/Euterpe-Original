namespace Assets.Scripts.Database;

public class LocalUILocalizationInfo : BaseDataObject
{
	private Dictionary<String, String> m_UiLocalization; //Field offset: 0x20

	public LocalUILocalizationInfo() { }

	public string GetDiff(int index) { }

	public string GetSceneName(string scene) { }

	public void InitLocal(Dictionary<String, String> dic) { }

	public bool TryGetValue(string key, out string value) { }

	public string TryGetValue(string key) { }

}

