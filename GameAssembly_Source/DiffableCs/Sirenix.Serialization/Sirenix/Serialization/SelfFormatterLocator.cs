namespace Sirenix.Serialization;

internal class SelfFormatterLocator : IFormatterLocator
{

	public SelfFormatterLocator() { }

	public override bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, out IFormatter formatter) { }

}

