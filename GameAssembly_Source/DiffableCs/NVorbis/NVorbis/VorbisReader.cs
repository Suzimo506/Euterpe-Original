namespace NVorbis;

public class VorbisReader : IDisposable
{
	[CompilerGenerated]
	private static Func<VorbisStreamDecoder, VorbisStreamDecoder> CS$<>9__CachedAnonymousMethodDelegate1; //Field offset: 0x0
	private int _streamIdx; //Field offset: 0x10
	private IContainerReader _containerReader; //Field offset: 0x18
	private List<VorbisStreamDecoder> _decoders; //Field offset: 0x20
	private List<Int32> _serials; //Field offset: 0x28
	[CompilerGenerated]
	private bool <ClipSamples>k__BackingField; //Field offset: 0x30

	private VorbisStreamDecoder ActiveDecoder
	{
		private get { } //Length: 133
	}

	public int Channels
	{
		 get { } //Length: 29
	}

	public bool ClipSamples
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public String[] Comments
	{
		 get { } //Length: 30
	}

	public long ContainerOverheadBits
	{
		 get { } //Length: 87
	}

	public TimeSpan DecodedTime
	{
		 get { } //Length: 153
		 set { } //Length: 118
	}

	public bool IsParameterChange
	{
		 get { } //Length: 33
	}

	public int LowerBitrate
	{
		 get { } //Length: 29
	}

	public int NominalBitrate
	{
		 get { } //Length: 29
	}

	public int SampleRate
	{
		 get { } //Length: 29
	}

	public IVorbisStreamStatus[] Stats
	{
		 get { } //Length: 200
	}

	public int StreamCount
	{
		 get { } //Length: 59
	}

	public int StreamIndex
	{
		 get { } //Length: 4
	}

	public TimeSpan TotalTime
	{
		 get { } //Length: 318
	}

	public int UpperBitrate
	{
		 get { } //Length: 29
	}

	public string Vendor
	{
		 get { } //Length: 30
	}

	private VorbisReader() { }

	public VorbisReader(string fileName) { }

	public VorbisReader(Stream stream, bool closeStreamOnDispose) { }

	[CompilerGenerated]
	private static VorbisStreamDecoder <get_Stats>b__0(VorbisStreamDecoder d) { }

	public void ClearParameterChange() { }

	public override void Dispose() { }

	public bool FindNextStream() { }

	private VorbisStreamDecoder get_ActiveDecoder() { }

	public int get_Channels() { }

	[CompilerGenerated]
	public bool get_ClipSamples() { }

	public String[] get_Comments() { }

	public long get_ContainerOverheadBits() { }

	public TimeSpan get_DecodedTime() { }

	public bool get_IsParameterChange() { }

	public int get_LowerBitrate() { }

	public int get_NominalBitrate() { }

	public int get_SampleRate() { }

	public IVorbisStreamStatus[] get_Stats() { }

	public int get_StreamCount() { }

	public int get_StreamIndex() { }

	public TimeSpan get_TotalTime() { }

	public int get_UpperBitrate() { }

	public string get_Vendor() { }

	private bool LoadContainer(IContainerReader containerReader) { }

	private void NewStream(object sender, NewStreamEventArgs ea) { }

	public int ReadSamples(Single[] buffer, int offset, int count) { }

	[CompilerGenerated]
	public void set_ClipSamples(bool value) { }

	public void set_DecodedTime(TimeSpan value) { }

	public bool SwitchStreams(int index) { }

}

