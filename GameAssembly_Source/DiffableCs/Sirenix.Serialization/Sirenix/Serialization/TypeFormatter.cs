namespace Sirenix.Serialization;

public sealed class TypeFormatter : MinimalBaseFormatter<Type>
{

	public TypeFormatter() { }

	protected virtual Type GetUninitializedObject() { }

	protected virtual void Read(ref Type value, IDataReader reader) { }

	protected virtual void Write(ref Type value, IDataWriter writer) { }

}

