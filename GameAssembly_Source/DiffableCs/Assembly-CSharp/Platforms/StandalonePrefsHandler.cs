namespace Platforms;

public class StandalonePrefsHandler : PrefsHandler
{
	private string m_SaveLocation; //Field offset: 0x10
	private Dictionary<String, String> m_Content; //Field offset: 0x18

	public StandalonePrefsHandler() { }

	public virtual void ClearAllPrefs() { }

	public virtual void Delete(string key) { }

	public virtual string GetString(string key) { }

	private void LoadContent() { }

	public virtual void Save() { }

	private void SaveContent() { }

	public virtual void SaveString(string key, string s) { }

}

