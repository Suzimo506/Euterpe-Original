namespace Sirenix.Serialization;

public sealed class DateTimeOffsetFormatter : MinimalBaseFormatter<DateTimeOffset>
{

	public DateTimeOffsetFormatter() { }

	protected virtual void Read(ref DateTimeOffset value, IDataReader reader) { }

	protected virtual void Write(ref DateTimeOffset value, IDataWriter writer) { }

}

