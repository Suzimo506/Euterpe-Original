namespace NAudio.Wave;

public interface IMp3FrameDecompressor : IDisposable
{

	public WaveFormat OutputFormat
	{
		 get { } //Length: 0
	}

	public int DecompressFrame(Mp3Frame frame, Byte[] dest, int destOffset) { }

	public WaveFormat get_OutputFormat() { }

	public void Reset() { }

}

