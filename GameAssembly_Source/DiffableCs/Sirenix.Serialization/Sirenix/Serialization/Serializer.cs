namespace Sirenix.Serialization;

public abstract class Serializer
{
	private static readonly Dictionary<Type, Type> PrimitiveReaderWriterTypes; //Field offset: 0x0
	private static readonly object LOCK; //Field offset: 0x8
	private static readonly Dictionary<Type, Serializer> ReaderWriterCache; //Field offset: 0x10

	private static Serializer() { }

	protected Serializer() { }

	private static Serializer Create(Type type) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected static void FireOnSerializedType(Type type) { }

	public static Serializer<T> Get() { }

	public static Serializer Get(Type type) { }

	public static Serializer GetForValue(object value) { }

	private static void LogAOTError(Type type, ExecutionEngineException ex) { }

	public abstract object ReadValueWeak(IDataReader reader) { }

	public void WriteValueWeak(object value, IDataWriter writer) { }

	public abstract void WriteValueWeak(string name, object value, IDataWriter writer) { }

}

