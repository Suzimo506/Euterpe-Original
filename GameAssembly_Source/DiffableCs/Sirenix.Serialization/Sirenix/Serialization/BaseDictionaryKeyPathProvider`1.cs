namespace Sirenix.Serialization;

public abstract class BaseDictionaryKeyPathProvider : IDictionaryKeyPathProvider<T>, IDictionaryKeyPathProvider, IComparer<T>
{

	public abstract string ProviderID
	{
		 get { } //Length: 0
	}

	protected BaseDictionaryKeyPathProvider`1() { }

	public abstract int Compare(T x, T y) { }

	public abstract string get_ProviderID() { }

	public abstract T GetKeyFromPathString(string pathStr) { }

	public abstract string GetPathStringFromKey(T key) { }

	private override int Sirenix.Serialization.IDictionaryKeyPathProvider.Compare(object x, object y) { }

	private override object Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString(string pathStr) { }

	private override string Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey(object key) { }

}

