namespace Sirenix.Serialization;

public class ColorFormatter : MinimalBaseFormatter<Color>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x68331

	private static ColorFormatter() { }

	public ColorFormatter() { }

	protected virtual void Read(ref Color value, IDataReader reader) { }

	protected virtual void Write(ref Color value, IDataWriter writer) { }

}

