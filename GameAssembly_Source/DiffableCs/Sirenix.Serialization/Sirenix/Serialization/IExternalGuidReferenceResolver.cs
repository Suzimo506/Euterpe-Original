namespace Sirenix.Serialization;

public interface IExternalGuidReferenceResolver
{

	public IExternalGuidReferenceResolver NextResolver
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool CanReference(object value, out Guid guid) { }

	public IExternalGuidReferenceResolver get_NextResolver() { }

	public void set_NextResolver(IExternalGuidReferenceResolver value) { }

	public bool TryResolveReference(Guid guid, out object value) { }

}

