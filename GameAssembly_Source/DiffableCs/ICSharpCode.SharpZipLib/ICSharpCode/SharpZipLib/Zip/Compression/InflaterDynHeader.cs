namespace ICSharpCode.SharpZipLib.Zip.Compression;

internal class InflaterDynHeader
{
	private static readonly Int32[] repMin; //Field offset: 0x0
	private static readonly Int32[] repBits; //Field offset: 0x8
	private static readonly Int32[] BL_ORDER; //Field offset: 0x10
	private Byte[] blLens; //Field offset: 0x10
	private Byte[] litdistLens; //Field offset: 0x18
	private InflaterHuffmanTree blTree; //Field offset: 0x20
	private int mode; //Field offset: 0x28
	private int lnum; //Field offset: 0x2C
	private int dnum; //Field offset: 0x30
	private int blnum; //Field offset: 0x34
	private int num; //Field offset: 0x38
	private int repSymbol; //Field offset: 0x3C
	private byte lastLen; //Field offset: 0x40
	private int ptr; //Field offset: 0x44

	private static InflaterDynHeader() { }

	public InflaterDynHeader() { }

	public InflaterHuffmanTree BuildDistTree() { }

	public InflaterHuffmanTree BuildLitLenTree() { }

	public bool Decode(StreamManipulator input) { }

}

