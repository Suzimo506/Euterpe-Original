namespace Sirenix.Serialization;

public class BoundsFormatter : MinimalBaseFormatter<Bounds>
{
	private static readonly Serializer<Vector3> Vector3Serializer; //Field offset: 0x2C927B4

	private static BoundsFormatter() { }

	public BoundsFormatter() { }

	protected virtual void Read(ref Bounds value, IDataReader reader) { }

	protected virtual void Write(ref Bounds value, IDataWriter writer) { }

}

