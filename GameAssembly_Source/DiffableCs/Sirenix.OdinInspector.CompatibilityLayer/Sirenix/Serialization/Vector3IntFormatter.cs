namespace Sirenix.Serialization;

public class Vector3IntFormatter : MinimalBaseFormatter<Vector3Int>
{
	private static readonly Serializer<Int32> Serializer; //Field offset: 0x64A4E

	private static Vector3IntFormatter() { }

	protected virtual void Read(ref Vector3Int value, IDataReader reader) { }

	protected virtual void Write(ref Vector3Int value, IDataWriter writer) { }

}

