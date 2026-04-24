namespace Sirenix.Serialization;

public sealed class SelfFormatterFormatter : BaseFormatter<T>
{

	public SelfFormatterFormatter`1() { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

}

