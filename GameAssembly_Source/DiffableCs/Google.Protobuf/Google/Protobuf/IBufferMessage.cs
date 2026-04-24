namespace Google.Protobuf;

public interface IBufferMessage : IMessage
{

	public void InternalMergeFrom(ref ParseContext ctx) { }

	public void InternalWriteTo(ref WriteContext ctx) { }

}

