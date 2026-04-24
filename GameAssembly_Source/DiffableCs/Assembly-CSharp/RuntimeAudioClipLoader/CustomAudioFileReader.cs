namespace RuntimeAudioClipLoader;

internal class CustomAudioFileReader : WaveStream, ISampleProvider
{
	private WaveStream readerStream; //Field offset: 0x28
	private readonly SampleChannel sampleChannel; //Field offset: 0x30
	private readonly int destBytesPerSample; //Field offset: 0x38
	private readonly int sourceBytesPerSample; //Field offset: 0x3C
	private readonly long length; //Field offset: 0x40
	private readonly object lockObject; //Field offset: 0x48

	public virtual long Length
	{
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 187
	}

	public float Volume
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public virtual WaveFormat WaveFormat
	{
		 get { } //Length: 27
	}

	public CustomAudioFileReader(Stream stream, AudioFormat format) { }

	private void CreateReaderStream(Stream stream, AudioFormat format) { }

	private long DestToSource(long destBytes) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public float get_Volume() { }

	public virtual WaveFormat get_WaveFormat() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public override int Read(Single[] buffer, int offset, int count) { }

	public virtual void set_Position(long value) { }

	public void set_Volume(float value) { }

	private long SourceToDest(long sourceBytes) { }

}

