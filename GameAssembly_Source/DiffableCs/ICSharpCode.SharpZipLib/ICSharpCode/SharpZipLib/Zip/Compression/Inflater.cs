namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class Inflater
{
	private static readonly Int32[] CPLENS; //Field offset: 0x0
	private static readonly Int32[] CPLEXT; //Field offset: 0x8
	private static readonly Int32[] CPDIST; //Field offset: 0x10
	private static readonly Int32[] CPDEXT; //Field offset: 0x18
	private int mode; //Field offset: 0x10
	private int readAdler; //Field offset: 0x14
	private int neededBits; //Field offset: 0x18
	private int repLength; //Field offset: 0x1C
	private int repDist; //Field offset: 0x20
	private int uncomprLen; //Field offset: 0x24
	private bool isLastBlock; //Field offset: 0x28
	private long totalOut; //Field offset: 0x30
	private long totalIn; //Field offset: 0x38
	private bool noHeader; //Field offset: 0x40
	private StreamManipulator input; //Field offset: 0x48
	private OutputWindow outputWindow; //Field offset: 0x50
	private InflaterDynHeader dynHeader; //Field offset: 0x58
	private InflaterHuffmanTree litlenTree; //Field offset: 0x60
	private InflaterHuffmanTree distTree; //Field offset: 0x68
	private Adler32 adler; //Field offset: 0x70

	public bool IsFinished
	{
		 get { } //Length: 44
	}

	public bool IsNeedingDictionary
	{
		 get { } //Length: 17
	}

	public bool IsNeedingInput
	{
		 get { } //Length: 32
	}

	private static Inflater() { }

	public Inflater(bool noHeader) { }

	private bool Decode() { }

	private bool DecodeChksum() { }

	private bool DecodeDict() { }

	private bool DecodeHeader() { }

	private bool DecodeHuffman() { }

	public bool get_IsFinished() { }

	public bool get_IsNeedingDictionary() { }

	public bool get_IsNeedingInput() { }

	public int Inflate(Byte[] buffer, int offset, int count) { }

	public void SetInput(Byte[] buffer, int index, int count) { }

}

