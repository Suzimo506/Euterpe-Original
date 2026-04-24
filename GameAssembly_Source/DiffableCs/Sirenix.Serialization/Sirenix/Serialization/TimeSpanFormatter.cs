namespace Sirenix.Serialization;

public sealed class TimeSpanFormatter : MinimalBaseFormatter<TimeSpan>
{

	public TimeSpanFormatter() { }

	protected virtual void Read(ref TimeSpan value, IDataReader reader) { }

	protected virtual void Write(ref TimeSpan value, IDataWriter writer) { }

}

