namespace Sirenix.Serialization;

public class RectFormatter : MinimalBaseFormatter<Rect>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x2C927BC

	private static RectFormatter() { }

	public RectFormatter() { }

	protected virtual void Read(ref Rect value, IDataReader reader) { }

	protected virtual void Write(ref Rect value, IDataWriter writer) { }

}

