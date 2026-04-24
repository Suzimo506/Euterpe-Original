namespace Sirenix.Serialization;

public class SerializationConfig
{
	private readonly object LOCK; //Field offset: 0x10
	private ISerializationPolicy serializationPolicy; //Field offset: 0x18
	private DebugContext debugContext; //Field offset: 0x20
	public bool AllowDeserializeInvalidData; //Field offset: 0x28

	public DebugContext DebugContext
	{
		 get { } //Length: 239
		 set { } //Length: 141
	}

	public ISerializationPolicy SerializationPolicy
	{
		 get { } //Length: 258
		 set { } //Length: 141
	}

	public SerializationConfig() { }

	public DebugContext get_DebugContext() { }

	public ISerializationPolicy get_SerializationPolicy() { }

	public void ResetToDefault() { }

	public void set_DebugContext(DebugContext value) { }

	public void set_SerializationPolicy(ISerializationPolicy value) { }

}

