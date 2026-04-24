namespace Sirenix.Serialization;

public class ColorBlockFormatter : MinimalBaseFormatter<T>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x0
	private static readonly Serializer<Color> ColorSerializer; //Field offset: 0x0
	private static readonly PropertyInfo normalColor; //Field offset: 0x0
	private static readonly PropertyInfo highlightedColor; //Field offset: 0x0
	private static readonly PropertyInfo pressedColor; //Field offset: 0x0
	private static readonly PropertyInfo disabledColor; //Field offset: 0x0
	private static readonly PropertyInfo colorMultiplier; //Field offset: 0x0
	private static readonly PropertyInfo fadeDuration; //Field offset: 0x0

	private static ColorBlockFormatter`1() { }

	public ColorBlockFormatter`1() { }

	protected virtual void Read(ref T value, IDataReader reader) { }

	protected virtual void Write(ref T value, IDataWriter writer) { }

}

