namespace Google.Protobuf;

public sealed class InvalidProtocolBufferException : IOException
{

	internal InvalidProtocolBufferException(string message) { }

	internal static InvalidProtocolBufferException InvalidEndTag() { }

	internal static InvalidProtocolBufferException InvalidTag() { }

	internal static InvalidProtocolBufferException InvalidWireType() { }

	internal static InvalidProtocolBufferException MalformedVarint() { }

	internal static InvalidProtocolBufferException MoreDataAvailable() { }

	internal static InvalidProtocolBufferException NegativeSize() { }

	internal static InvalidProtocolBufferException RecursionLimitExceeded() { }

	internal static InvalidProtocolBufferException SizeLimitExceeded() { }

	internal static InvalidProtocolBufferException TruncatedMessage() { }

}

