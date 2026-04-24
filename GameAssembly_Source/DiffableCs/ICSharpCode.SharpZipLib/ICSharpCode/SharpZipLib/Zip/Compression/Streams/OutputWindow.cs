namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class OutputWindow
{
	private Byte[] window; //Field offset: 0x10
	private int windowEnd; //Field offset: 0x18
	private int windowFilled; //Field offset: 0x1C

	public OutputWindow() { }

	public int CopyOutput(Byte[] output, int offset, int len) { }

	public int CopyStored(StreamManipulator input, int length) { }

	public int GetAvailable() { }

	public int GetFreeSpace() { }

	public void Repeat(int length, int distance) { }

	private void SlowRepeat(int repStart, int length, int distance) { }

	public void Write(int value) { }

}

