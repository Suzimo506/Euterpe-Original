namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class InflaterHuffmanTree
{
	public static InflaterHuffmanTree defLitLenTree; //Field offset: 0x0
	public static InflaterHuffmanTree defDistTree; //Field offset: 0x8
	private Int16[] tree; //Field offset: 0x10

	private static InflaterHuffmanTree() { }

	public InflaterHuffmanTree(Byte[] codeLengths) { }

	private void BuildTree(Byte[] codeLengths) { }

	public int GetSymbol(StreamManipulator input) { }

}

