namespace Sirenix.Serialization;

public class Vector2IntFormatter : MinimalBaseFormatter<Vector2Int>
{
	private static readonly Serializer<Int32> Serializer; //Field offset: 0x64A10

	private static Vector2IntFormatter() { }

	public Vector2IntFormatter() { }

	protected virtual void Read(ref Vector2Int value, IDataReader reader) { }

	protected virtual void Write(ref Vector2Int value, IDataWriter writer) { }

}

