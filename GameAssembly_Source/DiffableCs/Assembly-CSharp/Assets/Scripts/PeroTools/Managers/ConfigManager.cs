namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ConfigManager : Singleton<ConfigManager>
{
	private static Dictionary<Type, String> s_TypeDic; //Field offset: 0x0
	private DBConfig m_DbConfig; //Field offset: 0x10
	[Obsolete]
	private readonly Dictionary<String, JArray> m_Dictionary; //Field offset: 0x18
	[Obsolete]
	private readonly Dictionary<String, TextAsset> m_TextAssets; //Field offset: 0x20
	private PrefsHandler m_PrefsHandler; //Field offset: 0x28

	[Obsolete]
	public JArray Item
	{
		 get { } //Length: 11
	}

	private static ConfigManager() { }

	public ConfigManager() { }

	public void Add(string key, string data) { }

	public void Clear() { }

	public void ClearAllPrefs() { }

	public JToken Convert(string path) { }

	public void Delete(string fileName) { }

	public JArray get_Item(string jsonName) { }

	[Obsolete]
	public bool GetConfigBoolValue(string fileName, string cmpKey, string targetKey, object cmpValue) { }

	[Obsolete]
	public bool GetConfigBoolValue(string fileName, int index, string key) { }

	[Obsolete]
	public float GetConfigFloatValue(string fileName, int index, string key) { }

	[Obsolete]
	public float GetConfigFloatValue(string fileName, string cmpKey, string targetKey, object cmpValue) { }

	[Obsolete]
	public int GetConfigIndex(string fileName, string cmpKey, object cmpValue) { }

	[Obsolete]
	public int GetConfigIntValue(string fileName, int index, string key) { }

	[Obsolete]
	public int GetConfigIntValue(string fileName, string cmpKey, string targetKey, object cmpValue) { }

	private BaseDBConfigObject GetConfigObject(Type t, int albumIndex = -1) { }

	private BaseDBConfigObject GetConfigObject(Type type, string name) { }

	public T GetConfigObject(int albumIndex = -1) { }

	[Obsolete]
	public string GetConfigStringValue(string fileName, int index, string key) { }

	[Obsolete]
	public string GetConfigStringValue(string fileName, string cmpKey, string targetKey, object cmpValue) { }

	[Obsolete]
	public JToken GetConfigToken(string fileName, int index, string key) { }

	[Obsolete]
	public JToken GetConfigToken(string fileName, string cmpKey, string targetKey, object cmpValue) { }

	[Obsolete]
	public JArray GetJson(string name, bool localization) { }

	[Obsolete]
	public T GetObject(string fileName) { }

	[Obsolete]
	public object GetObject(string fileName, Type type) { }

	public string GetString(string fileName) { }

	private void Init() { }

	private void InitPrefsHandler() { }

	private BaseDBConfigObject LoadConfigFile(string name, Type type, bool cache = false) { }

	public void Remove(string key) { }

	public void Save() { }

	public void SaveObject(string fileName, object obj) { }

	public void SaveString(string fileName, string s) { }

}

