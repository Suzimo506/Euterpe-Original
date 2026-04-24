namespace Sirenix.Serialization;

public class GradientFormatter : MinimalBaseFormatter<Gradient>
{
	private static readonly Serializer<GradientAlphaKey[]> AlphaKeysSerializer; //Field offset: 0x0
	private static readonly Serializer<GradientColorKey[]> ColorKeysSerializer; //Field offset: 0x8
	private static readonly PropertyInfo ModeProperty; //Field offset: 0x10
	private static readonly Serializer<Object> EnumSerializer; //Field offset: 0x18

	private static GradientFormatter() { }

	public GradientFormatter() { }

	protected virtual Gradient GetUninitializedObject() { }

	protected virtual void Read(ref Gradient value, IDataReader reader) { }

	protected virtual void Write(ref Gradient value, IDataWriter writer) { }

}

