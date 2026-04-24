namespace Sirenix.Serialization;

public interface IDictionaryKeyPathProvider
{

	public string ProviderID
	{
		 get { } //Length: 0
	}

	public int Compare(object x, object y) { }

	public string get_ProviderID() { }

	public object GetKeyFromPathString(string pathStr) { }

	public string GetPathStringFromKey(object key) { }

}

