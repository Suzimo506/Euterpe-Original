namespace Sirenix.Serialization;

public sealed class DeserializationContext : ICacheNotificationReceiver
{
	private SerializationConfig config; //Field offset: 0x10
	private Dictionary<Int32, Object> internalIdReferenceMap; //Field offset: 0x18
	private StreamingContext streamingContext; //Field offset: 0x20
	private IFormatterConverter formatterConverter; //Field offset: 0x30
	private TwoWaySerializationBinder binder; //Field offset: 0x38
	[CompilerGenerated]
	private IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField; //Field offset: 0x50

	public TwoWaySerializationBinder Binder
	{
		 get { } //Length: 113
		 set { } //Length: 12
	}

	public SerializationConfig Config
	{
		 get { } //Length: 106
		 set { } //Length: 12
	}

	public IFormatterConverter FormatterConverter
	{
		 get { } //Length: 5
	}

	public IExternalGuidReferenceResolver GuidReferenceResolver
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public IExternalIndexReferenceResolver IndexReferenceResolver
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public StreamingContext StreamingContext
	{
		 get { } //Length: 11
	}

	public IExternalStringReferenceResolver StringReferenceResolver
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public DeserializationContext() { }

	public DeserializationContext(StreamingContext context) { }

	public DeserializationContext(FormatterConverter formatterConverter) { }

	public DeserializationContext(StreamingContext context, FormatterConverter formatterConverter) { }

	public TwoWaySerializationBinder get_Binder() { }

	public SerializationConfig get_Config() { }

	public IFormatterConverter get_FormatterConverter() { }

	[CompilerGenerated]
	public IExternalGuidReferenceResolver get_GuidReferenceResolver() { }

	[CompilerGenerated]
	public IExternalIndexReferenceResolver get_IndexReferenceResolver() { }

	public StreamingContext get_StreamingContext() { }

	[CompilerGenerated]
	public IExternalStringReferenceResolver get_StringReferenceResolver() { }

	public object GetExternalObject(Guid guid) { }

	public object GetExternalObject(int index) { }

	public object GetExternalObject(string id) { }

	public object GetInternalReference(int id) { }

	public void RegisterInternalReference(int id, object reference) { }

	public void Reset() { }

	public void set_Binder(TwoWaySerializationBinder value) { }

	public void set_Config(SerializationConfig value) { }

	[CompilerGenerated]
	public void set_GuidReferenceResolver(IExternalGuidReferenceResolver value) { }

	[CompilerGenerated]
	public void set_IndexReferenceResolver(IExternalIndexReferenceResolver value) { }

	[CompilerGenerated]
	public void set_StringReferenceResolver(IExternalStringReferenceResolver value) { }

	private override void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed() { }

	private override void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed() { }

}

