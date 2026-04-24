namespace Sirenix.Serialization;

public interface IDictionaryKeyPathProvider : IDictionaryKeyPathProvider
{

	public int Compare(T x, T y) { }

	public T GetKeyFromPathString(string pathStr) { }

	public string GetPathStringFromKey(T key) { }

}

