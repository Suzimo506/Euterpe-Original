namespace NVorbis.NAudioSupport;

internal class VorbisWaveReader : WaveStream, IDisposable, ISampleProvider, IWaveProvider
{
	[ThreadStatic]
	private static Single[] _conversionBuffer; //Field offset: 0x80000000
	private VorbisReader _reader; //Field offset: 0x28
	private WaveFormat _waveFormat; //Field offset: 0x30
	[CompilerGenerated]
	private Nullable<Int32> <NextStreamIndex>k__BackingField; //Field offset: 0x38

	public String[] Comments
	{
		 get { } //Length: 29
	}

	public long ContainerOverheadBits
	{
		 get { } //Length: 29
	}

	public int CurrentStream
	{
		 get { } //Length: 26
		 set { } //Length: 179
	}

	public bool IsParameterChange
	{
		 get { } //Length: 29
	}

	public virtual long Length
	{
		 get { } //Length: 104
	}

	public int LowerBitrate
	{
		 get { } //Length: 29
	}

	public Nullable<Int32> NextStreamIndex
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int NominalBitrate
	{
		 get { } //Length: 29
	}

	public virtual long Position
	{
		 get { } //Length: 146
		 set { } //Length: 302
	}

	public IVorbisStreamStatus[] Stats
	{
		 get { } //Length: 29
	}

	public int StreamCount
	{
		 get { } //Length: 29
	}

	public int UpperBitrate
	{
		 get { } //Length: 29
	}

	public string Vendor
	{
		 get { } //Length: 29
	}

	public virtual WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	private static VorbisWaveReader() { }

	public VorbisWaveReader(string fileName) { }

	public VorbisWaveReader(Stream sourceStream) { }

	public void ClearParameterChange() { }

	protected virtual void Dispose(bool disposing) { }

	public String[] get_Comments() { }

	public long get_ContainerOverheadBits() { }

	public int get_CurrentStream() { }

	public bool get_IsParameterChange() { }

	public virtual long get_Length() { }

	public int get_LowerBitrate() { }

	[CompilerGenerated]
	public Nullable<Int32> get_NextStreamIndex() { }

	public int get_NominalBitrate() { }

	public virtual long get_Position() { }

	public IVorbisStreamStatus[] get_Stats() { }

	public int get_StreamCount() { }

	public int get_UpperBitrate() { }

	public string get_Vendor() { }

	public virtual WaveFormat get_WaveFormat() { }

	public bool GetNextStreamIndex() { }

	public override int Read(Single[] buffer, int offset, int count) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public void set_CurrentStream(int value) { }

	[CompilerGenerated]
	public void set_NextStreamIndex(Nullable<Int32> value) { }

	public virtual void set_Position(long value) { }

}

