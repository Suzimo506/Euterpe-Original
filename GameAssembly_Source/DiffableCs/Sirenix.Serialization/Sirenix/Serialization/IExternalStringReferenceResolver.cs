namespace Sirenix.Serialization;

public interface IExternalStringReferenceResolver
{

	public IExternalStringReferenceResolver NextResolver
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool CanReference(object value, out string id) { }

	public IExternalStringReferenceResolver get_NextResolver() { }

	public void set_NextResolver(IExternalStringReferenceResolver value) { }

	public bool TryResolveReference(string id, out object value) { }

}

