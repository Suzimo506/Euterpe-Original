namespace PeroTools.Saves;

public class DefaultPrefsHandler : PrefsHandler
{

	public DefaultPrefsHandler() { }

	public virtual void ClearAllPrefs() { }

	public virtual void Delete(string key) { }

	public virtual string GetString(string key) { }

	public virtual void Save() { }

	public virtual void SaveString(string key, string s) { }

}

