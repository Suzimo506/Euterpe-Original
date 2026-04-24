namespace Sirenix.Serialization;

public class Vector4Formatter : MinimalBaseFormatter<Vector4>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x2C927B4

	private static Vector4Formatter() { }

	public Vector4Formatter() { }

	protected virtual void Read(ref Vector4 value, IDataReader reader) { }

	protected virtual void Write(ref Vector4 value, IDataWriter writer) { }

}

