namespace Sirenix.Serialization;

public class GradientAlphaKeyFormatter : MinimalBaseFormatter<GradientAlphaKey>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x2C92858

	private static GradientAlphaKeyFormatter() { }

	public GradientAlphaKeyFormatter() { }

	protected virtual void Read(ref GradientAlphaKey value, IDataReader reader) { }

	protected virtual void Write(ref GradientAlphaKey value, IDataWriter writer) { }

}

