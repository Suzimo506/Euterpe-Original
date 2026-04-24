namespace Sirenix.Serialization;

public interface IExternalIndexReferenceResolver
{

	public bool CanReference(object value, out int index) { }

	public bool TryResolveReference(int index, out object value) { }

}

