namespace Sirenix.Serialization;

public abstract class TwoWaySerializationBinder
{
	public static readonly TwoWaySerializationBinder Default; //Field offset: 0x6827C

	private static TwoWaySerializationBinder() { }

	protected TwoWaySerializationBinder() { }

	public abstract string BindToName(Type type, DebugContext debugContext = null) { }

	public abstract Type BindToType(string typeName, DebugContext debugContext = null) { }

	public abstract bool ContainsType(string typeName) { }

}

