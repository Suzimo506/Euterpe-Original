namespace NAudio.Wave.Compression;

public class AcmStream : IDisposable
{
	private IntPtr streamHandle; //Field offset: 0x10
	private IntPtr driverHandle; //Field offset: 0x18
	private AcmStreamHeader streamHeader; //Field offset: 0x20
	private WaveFormat sourceFormat; //Field offset: 0x28

	public Byte[] DestBuffer
	{
		 get { } //Length: 27
	}

	public Byte[] SourceBuffer
	{
		 get { } //Length: 27
	}

	public AcmStream(WaveFormat sourceFormat, WaveFormat destFormat) { }

	public int Convert(int bytesToConvert, out int sourceBytesConverted) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public Byte[] get_DestBuffer() { }

	public Byte[] get_SourceBuffer() { }

	public void Reposition() { }

	public int SourceToDest(int source) { }

	public static WaveFormat SuggestPcmFormat(WaveFormat compressedFormat) { }

}

