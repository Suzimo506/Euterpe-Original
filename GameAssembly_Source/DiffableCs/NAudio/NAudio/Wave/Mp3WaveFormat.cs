namespace NAudio.Wave;

public class Mp3WaveFormat : WaveFormat
{
	public Mp3WaveFormatId id; //Field offset: 0x22
	public Mp3WaveFormatFlags flags; //Field offset: 0x24
	public ushort blockSize; //Field offset: 0x28
	public ushort framesPerBlock; //Field offset: 0x2A
	public ushort codecDelay; //Field offset: 0x2C

	public Mp3WaveFormat(int sampleRate, int channels, int blockSize, int bitRate) { }

}

