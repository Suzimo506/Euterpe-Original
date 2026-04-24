namespace Sirenix.Serialization;

public sealed class VersionFormatter : MinimalBaseFormatter<Version>
{

	public VersionFormatter() { }

	protected virtual Version GetUninitializedObject() { }

	protected virtual void Read(ref Version value, IDataReader reader) { }

	protected virtual void Write(ref Version value, IDataWriter writer) { }

}

