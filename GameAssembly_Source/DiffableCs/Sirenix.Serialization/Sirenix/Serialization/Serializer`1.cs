namespace Sirenix.Serialization;

public abstract class Serializer : Serializer
{

	protected Serializer`1() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected static void FireOnSerializedType() { }

	public abstract T ReadValue(IDataReader reader) { }

	public virtual object ReadValueWeak(IDataReader reader) { }

	public void WriteValue(T value, IDataWriter writer) { }

	public abstract void WriteValue(string name, T value, IDataWriter writer) { }

	public virtual void WriteValueWeak(string name, object value, IDataWriter writer) { }

}

