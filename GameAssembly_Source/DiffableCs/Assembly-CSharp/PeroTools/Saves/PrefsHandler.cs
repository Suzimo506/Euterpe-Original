namespace PeroTools.Saves;

public abstract class PrefsHandler
{

	protected PrefsHandler() { }

	public abstract void ClearAllPrefs() { }

	public abstract void Delete(string key) { }

	public abstract string GetString(string key) { }

	public abstract void Save() { }

	public abstract void SaveString(string key, string s) { }

}

