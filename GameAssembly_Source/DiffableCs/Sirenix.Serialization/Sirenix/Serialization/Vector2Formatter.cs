namespace Sirenix.Serialization;

public class Vector2Formatter : MinimalBaseFormatter<Vector2>
{
	private static readonly Serializer<Single> FloatSerializer; //Field offset: 0x683A0

	private static Vector2Formatter() { }

	public Vector2Formatter() { }

	protected virtual void Read(ref Vector2 value, IDataReader reader) { }

	protected virtual void Write(ref Vector2 value, IDataWriter writer) { }

}

