namespace Sirenix.Serialization;

public class GradientColorKeyFormatter : MinimalBaseFormatter<GradientColorKey>
{
	private static readonly Serializer<Color> ColorSerializer; //Field offset: 0x0
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x8

	private static GradientColorKeyFormatter() { }

	public GradientColorKeyFormatter() { }

	protected virtual void Read(ref GradientColorKey value, IDataReader reader) { }

	protected virtual void Write(ref GradientColorKey value, IDataWriter writer) { }

}

