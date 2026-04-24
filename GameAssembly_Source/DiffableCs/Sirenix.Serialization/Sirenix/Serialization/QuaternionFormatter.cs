namespace Sirenix.Serialization;

public class QuaternionFormatter : MinimalBaseFormatter<Quaternion>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x68391

	private static QuaternionFormatter() { }

	public QuaternionFormatter() { }

	protected virtual void Read(ref Quaternion value, IDataReader reader) { }

	protected virtual void Write(ref Quaternion value, IDataWriter writer) { }

}

