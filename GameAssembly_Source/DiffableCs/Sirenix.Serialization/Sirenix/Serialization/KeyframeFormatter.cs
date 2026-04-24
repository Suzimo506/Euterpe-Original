namespace Sirenix.Serialization;

public class KeyframeFormatter : MinimalBaseFormatter<Keyframe>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x0
	private static readonly Serializer<Int32> IntSerializer; //Field offset: 0x8
	private static readonly bool Is_In_2018_1_Or_Above; //Field offset: 0x10
	private static IFormatter<Keyframe> Formatter; //Field offset: 0x18

	private static KeyframeFormatter() { }

	public KeyframeFormatter() { }

	protected virtual void Read(ref Keyframe value, IDataReader reader) { }

	protected virtual void Write(ref Keyframe value, IDataWriter writer) { }

}

