namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class StreamManipulator
{
	private Byte[] window_; //Field offset: 0x10
	private int windowStart_; //Field offset: 0x18
	private int windowEnd_; //Field offset: 0x1C
	private uint buffer_; //Field offset: 0x20
	private int bitsInBuffer_; //Field offset: 0x24

	public int AvailableBits
	{
		 get { } //Length: 4
	}

	public int AvailableBytes
	{
		 get { } //Length: 13
	}

	public bool IsNeedingInput
	{
		 get { } //Length: 10
	}

	public StreamManipulator() { }

	public int CopyBytes(Byte[] output, int offset, int length) { }

	public void DropBits(int bitCount) { }

	public int get_AvailableBits() { }

	public int get_AvailableBytes() { }

	public bool get_IsNeedingInput() { }

	public int PeekBits(int bitCount) { }

	public void SetInput(Byte[] buffer, int offset, int count) { }

	public void SkipToByteBoundary() { }

}

