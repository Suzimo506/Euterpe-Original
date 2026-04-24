namespace Sirenix.Serialization;

public interface ISelfFormatter
{

	public void Deserialize(IDataReader reader) { }

	public void Serialize(IDataWriter writer) { }

}

