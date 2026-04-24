namespace ProtoBuf;

public sealed class BufferExtension : IExtension
{
	private Byte[] buffer; //Field offset: 0x10

	public BufferExtension() { }

	private override Stream ProtoBuf.IExtension.BeginAppend() { }

	private override Stream ProtoBuf.IExtension.BeginQuery() { }

	private override void ProtoBuf.IExtension.EndAppend(Stream stream, bool commit) { }

	private override void ProtoBuf.IExtension.EndQuery(Stream stream) { }

	private override int ProtoBuf.IExtension.GetLength() { }

}

