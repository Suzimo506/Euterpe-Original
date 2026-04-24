namespace Sirenix.Serialization;

public sealed class SerializableFormatter : BaseFormatter<T>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ConstructorInfo constructor; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal T <.cctor>b__0(SerializationInfo info, StreamingContext context) { }

	}

	private static readonly Func<SerializationInfo, StreamingContext, T> ISerializableConstructor; //Field offset: 0x0
	private static readonly ReflectionFormatter<T> ReflectionFormatter; //Field offset: 0x0

	private static SerializableFormatter`1() { }

	public SerializableFormatter`1() { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	protected virtual T GetUninitializedObject() { }

	private SerializationInfo ReadSerializationInfo(IDataReader reader) { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

	private void WriteSerializationInfo(SerializationInfo info, IDataWriter writer) { }

}

