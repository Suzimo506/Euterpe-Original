namespace Sirenix.Serialization;

public interface IFormatter : IFormatter
{

	public T Deserialize(IDataReader reader) { }

	public void Serialize(T value, IDataWriter writer) { }

}

