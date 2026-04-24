namespace NAudio.Wave;

public class WaveFormatConversionStream : WaveStream
{
	private AcmStream conversionStream; //Field offset: 0x28
	private WaveStream sourceStream; //Field offset: 0x30
	private WaveFormat targetFormat; //Field offset: 0x38
	private long length; //Field offset: 0x40
	private long position; //Field offset: 0x48
	private int preferredSourceReadSize; //Field offset: 0x50
	private int leftoverDestBytes; //Field offset: 0x54
	private int leftoverDestOffset; //Field offset: 0x58
	private int leftoverSourceBytes; //Field offset: 0x5C

	public virtual long Length
	{
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 5
		 set { } //Length: 305
	}

	public virtual WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public WaveFormatConversionStream(WaveFormat targetFormat, WaveStream sourceStream) { }

	public static WaveStream CreatePcmStream(WaveStream sourceStream) { }

	protected virtual void Dispose(bool disposing) { }

	private long EstimateDestToSource(long dest) { }

	private long EstimateSourceToDest(long source) { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual WaveFormat get_WaveFormat() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual void set_Position(long value) { }

}

