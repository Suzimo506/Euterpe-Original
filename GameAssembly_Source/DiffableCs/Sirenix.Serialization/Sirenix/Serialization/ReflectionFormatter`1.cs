namespace Sirenix.Serialization;

public class ReflectionFormatter : BaseFormatter<T>
{
	[CompilerGenerated]
	private ISerializationPolicy <OverridePolicy>k__BackingField; //Field offset: 0x0

	public private ISerializationPolicy OverridePolicy
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public ReflectionFormatter`1() { }

	public ReflectionFormatter`1(ISerializationPolicy overridePolicy) { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	[CompilerGenerated]
	public ISerializationPolicy get_OverridePolicy() { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

	[CompilerGenerated]
	private void set_OverridePolicy(ISerializationPolicy value) { }

}

