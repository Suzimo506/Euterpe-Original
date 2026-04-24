namespace Antlr.Runtime;

public class ANTLRReaderStream : ANTLRStringStream
{
	public const int ReadBufferSize = 1024; //Field offset: 0x0
	public const int InitialBufferSize = 1024; //Field offset: 0x0

	public ANTLRReaderStream(TextReader r) { }

	public ANTLRReaderStream(TextReader r, int size) { }

	public ANTLRReaderStream(TextReader r, int size, int readChunkSize) { }

	public override void Load(TextReader r, int size, int readChunkSize) { }

}

