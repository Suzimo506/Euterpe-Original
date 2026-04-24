namespace Sirenix.Serialization;

public class Color32Formatter : MinimalBaseFormatter<Color32>
{
	private static readonly Serializer<Byte> ByteSerializer; //Field offset: 0x682A0

	private static Color32Formatter() { }

	public Color32Formatter() { }

	protected virtual void Read(ref Color32 value, IDataReader reader) { }

	protected virtual void Write(ref Color32 value, IDataWriter writer) { }

}

