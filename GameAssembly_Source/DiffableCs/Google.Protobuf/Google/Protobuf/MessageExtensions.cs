namespace Google.Protobuf;

[Extension]
public static class MessageExtensions
{

	[Extension]
	internal static void MergeFrom(IMessage message, Byte[] data, bool discardUnknownFields, ExtensionRegistry registry) { }

	[Extension]
	internal static void MergeFrom(IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry) { }

}

