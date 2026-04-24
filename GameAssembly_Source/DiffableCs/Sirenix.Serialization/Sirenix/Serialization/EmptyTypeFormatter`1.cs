namespace Sirenix.Serialization;

public class EmptyTypeFormatter : EasyBaseFormatter<T>
{

	public EmptyTypeFormatter`1() { }

	protected virtual void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader) { }

	protected virtual void WriteDataEntries(ref T value, IDataWriter writer) { }

}

