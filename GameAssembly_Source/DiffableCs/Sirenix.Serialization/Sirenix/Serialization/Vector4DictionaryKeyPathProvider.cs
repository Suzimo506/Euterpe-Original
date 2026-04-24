namespace Sirenix.Serialization;

public sealed class Vector4DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector4>
{

	public virtual string ProviderID
	{
		 get { } //Length: 43
	}

	public Vector4DictionaryKeyPathProvider() { }

	public virtual int Compare(Vector4 x, Vector4 y) { }

	public virtual string get_ProviderID() { }

	public virtual Vector4 GetKeyFromPathString(string pathStr) { }

	public virtual string GetPathStringFromKey(Vector4 key) { }

}

