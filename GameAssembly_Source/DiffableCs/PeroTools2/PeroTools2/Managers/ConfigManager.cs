namespace PeroTools2.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ConfigManager : Singleton<ConfigManager>
{
	private readonly Dictionary<String, JArray> m_Dictionary; //Field offset: 0x10
	private readonly Dictionary<String, TextAsset> m_TextAssets; //Field offset: 0x18

	public JArray Item
	{
		 get { } //Length: 763
	}

	public ConfigManager() { }

	public void Add(string key, string data) { }

	public void Clear() { }

	public void ClearAllPrefs() { }

	public JToken Convert(string path) { }

	public void Delete(string fileName) { }

	public JArray get_Item(string jsonName) { }

	public int GetConfigIndex(string fileName, string cmpKey, T cmpValue) { }

	public JToken GetConfigToken(string fileName, int index, string key) { }

	public JToken GetConfigToken(string fileName, string cmpKey, string targetKey, T cmpValue) { }

	public T GetConfigValue(string fileName, int index, string key) { }

	public T GetConfigValue(string fileName, string cmpKey, string targetKey, object cmpValue) { }

	public T GetObject(string fileName) { }

	public object GetObject(string fileName, Type type) { }

	public string GetString(string fileName) { }

	public void Remove(string key) { }

	public void Save() { }

	public void SaveObject(string fileName, object obj) { }

	public void SaveString(string fileName, string s) { }

}

