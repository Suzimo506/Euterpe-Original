namespace Google.Protobuf;

public class MessageParser
{
	private Func<IMessage> factory; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <DiscardUnknownFields>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly ExtensionRegistry <Extensions>k__BackingField; //Field offset: 0x20

	internal bool DiscardUnknownFields
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal ExtensionRegistry Extensions
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions) { }

	[CompilerGenerated]
	internal bool get_DiscardUnknownFields() { }

	[CompilerGenerated]
	internal ExtensionRegistry get_Extensions() { }

	public IMessage ParseFrom(ByteString data) { }

}

