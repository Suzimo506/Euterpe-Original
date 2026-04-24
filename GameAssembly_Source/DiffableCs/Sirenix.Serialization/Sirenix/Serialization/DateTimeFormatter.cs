namespace Sirenix.Serialization;

public sealed class DateTimeFormatter : MinimalBaseFormatter<DateTime>
{

	public DateTimeFormatter() { }

	protected virtual void Read(ref DateTime value, IDataReader reader) { }

	protected virtual void Write(ref DateTime value, IDataWriter writer) { }

}

