namespace NAudio.Wave;

public class WaveFormat
{
	protected WaveFormatEncoding waveFormatTag; //Field offset: 0x10
	protected short channels; //Field offset: 0x12
	protected int sampleRate; //Field offset: 0x14
	protected int averageBytesPerSecond; //Field offset: 0x18
	protected short blockAlign; //Field offset: 0x1C
	protected short bitsPerSample; //Field offset: 0x1E
	protected short extraSize; //Field offset: 0x20

	public int AverageBytesPerSecond
	{
		 get { } //Length: 4
	}

	public int BitsPerSample
	{
		 get { } //Length: 5
	}

	public override int BlockAlign
	{
		 get { } //Length: 5
	}

	public int Channels
	{
		 get { } //Length: 5
	}

	public WaveFormatEncoding Encoding
	{
		 get { } //Length: 5
	}

	public int SampleRate
	{
		 get { } //Length: 4
	}

	public WaveFormat() { }

	public WaveFormat(int rate, int bits, int channels) { }

	public static WaveFormat CreateIeeeFloatWaveFormat(int sampleRate, int channels) { }

	public virtual bool Equals(object obj) { }

	public static WaveFormat FromFormatChunk(BinaryReader br, int formatChunkLength) { }

	public int get_AverageBytesPerSecond() { }

	public int get_BitsPerSample() { }

	public override int get_BlockAlign() { }

	public int get_Channels() { }

	public WaveFormatEncoding get_Encoding() { }

	public int get_SampleRate() { }

	public virtual int GetHashCode() { }

	private void ReadWaveFormat(BinaryReader br, int formatChunkLength) { }

	public virtual string ToString() { }

}

