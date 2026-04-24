namespace Antlr.Runtime;

public class ANTLRInputStream : ANTLRReaderStream
{

	public ANTLRInputStream(Stream input) { }

	public ANTLRInputStream(Stream input, int size) { }

	public ANTLRInputStream(Stream input, Encoding encoding) { }

	public ANTLRInputStream(Stream input, int size, Encoding encoding) { }

	public ANTLRInputStream(Stream input, int size, int readBufferSize, Encoding encoding) { }

	private static StreamReader GetStreamReader(Stream input, Encoding encoding) { }

}

