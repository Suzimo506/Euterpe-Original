namespace Sirenix.Serialization;

public interface IFormatterLocator
{

	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, out IFormatter formatter) { }

}

