namespace NAudio.FileFormats.Wav;

internal class WaveFileChunkReader
{
	private WaveFormat waveFormat; //Field offset: 0x10
	private long dataChunkPosition; //Field offset: 0x18
	private long dataChunkLength; //Field offset: 0x20
	private List<RiffChunk> riffChunks; //Field offset: 0x28
	private readonly bool strictMode; //Field offset: 0x30
	private bool isRf64; //Field offset: 0x31
	private readonly bool storeAllChunks; //Field offset: 0x32
	private long riffSize; //Field offset: 0x38

	public long DataChunkLength
	{
		 get { } //Length: 5
	}

	public long DataChunkPosition
	{
		 get { } //Length: 5
	}

	public List<RiffChunk> RiffChunks
	{
		 get { } //Length: 5
	}

	public WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public WaveFileChunkReader() { }

	public long get_DataChunkLength() { }

	public long get_DataChunkPosition() { }

	public List<RiffChunk> get_RiffChunks() { }

	public WaveFormat get_WaveFormat() { }

	private static RiffChunk GetRiffChunk(Stream stream, int chunkIdentifier, int chunkLength) { }

	private void ReadDs64Chunk(BinaryReader reader) { }

	private void ReadRiffHeader(BinaryReader br) { }

	public void ReadWaveHeader(Stream stream) { }

}

