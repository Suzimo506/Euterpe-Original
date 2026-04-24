namespace Sirenix.Serialization;

public sealed class NullableFormatter : BaseFormatter<Nullable`1<T>>
{
	private static readonly Serializer<T> TSerializer; //Field offset: 0x0

	private static NullableFormatter`1() { }

	public NullableFormatter`1() { }

	protected virtual void DeserializeImplementation(ref Nullable<T>& value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref Nullable<T>& value, IDataWriter writer) { }

}

