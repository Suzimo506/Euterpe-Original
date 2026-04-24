namespace NAudio.Wave;

public class AcmMp3FrameDecompressor : IMp3FrameDecompressor, IDisposable
{
	private readonly AcmStream conversionStream; //Field offset: 0x10
	private readonly WaveFormat pcmFormat; //Field offset: 0x18
	private bool disposed; //Field offset: 0x20

	public override WaveFormat OutputFormat
	{
		 get { } //Length: 5
	}

	public AcmMp3FrameDecompressor(WaveFormat sourceFormat) { }

	public override int DecompressFrame(Mp3Frame frame, Byte[] dest, int destOffset) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public override WaveFormat get_OutputFormat() { }

	public override void Reset() { }

}

