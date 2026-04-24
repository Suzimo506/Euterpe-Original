namespace NAudio.Utils;

public class CircularBuffer
{
	private readonly Byte[] buffer; //Field offset: 0x10
	private readonly object lockObject; //Field offset: 0x18
	private int writePosition; //Field offset: 0x20
	private int readPosition; //Field offset: 0x24
	private int byteCount; //Field offset: 0x28

	public int Count
	{
		 get { } //Length: 4
	}

	public int MaxLength
	{
		 get { } //Length: 26
	}

	public CircularBuffer(int size) { }

	public void Advance(int count) { }

	public int get_Count() { }

	public int get_MaxLength() { }

	public int Read(Byte[] data, int offset, int count) { }

	public void Reset() { }

	public int Write(Byte[] data, int offset, int count) { }

}

