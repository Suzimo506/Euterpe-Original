namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class InflaterInputBuffer
{
	private int rawLength; //Field offset: 0x10
	private Byte[] rawData; //Field offset: 0x18
	private int clearTextLength; //Field offset: 0x20
	private Byte[] clearText; //Field offset: 0x28
	private int available; //Field offset: 0x30
	private ICryptoTransform cryptoTransform; //Field offset: 0x38
	private Stream inputStream; //Field offset: 0x40

	public int Available
	{
		 get { } //Length: 4
	}

	public int RawLength
	{
		 get { } //Length: 4
	}

	public InflaterInputBuffer(Stream stream, int bufferSize) { }

	public void Fill() { }

	public int get_Available() { }

	public int get_RawLength() { }

	public void SetInflaterInput(Inflater inflater) { }

}

