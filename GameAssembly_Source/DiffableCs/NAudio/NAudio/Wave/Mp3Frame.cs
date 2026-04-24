namespace NAudio.Wave;

public class Mp3Frame
{
	private static readonly Int32[3] bitRates; //Field offset: 0x0
	private static readonly Int32[2] samplesPerFrame; //Field offset: 0x8
	private static readonly Int32[] sampleRatesVersion1; //Field offset: 0x10
	private static readonly Int32[] sampleRatesVersion2; //Field offset: 0x18
	private static readonly Int32[] sampleRatesVersion25; //Field offset: 0x20
	[CompilerGenerated]
	private int <SampleRate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <FrameLength>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <BitRate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Byte[] <RawData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private MpegVersion <MpegVersion>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private MpegLayer <MpegLayer>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private ChannelMode <ChannelMode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <SampleCount>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <ChannelExtension>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <BitRateIndex>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <Copyright>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <CrcPresent>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	private long <FileOffset>k__BackingField; //Field offset: 0x48

	public private int BitRate
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int BitRateIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int ChannelExtension
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private ChannelMode ChannelMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool Copyright
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool CrcPresent
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private long FileOffset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private int FrameLength
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private MpegLayer MpegLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private MpegVersion MpegVersion
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Byte[] RawData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private int SampleCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int SampleRate
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static Mp3Frame() { }

	private Mp3Frame() { }

	[CompilerGenerated]
	public int get_BitRate() { }

	[CompilerGenerated]
	public int get_BitRateIndex() { }

	[CompilerGenerated]
	public int get_ChannelExtension() { }

	[CompilerGenerated]
	public ChannelMode get_ChannelMode() { }

	[CompilerGenerated]
	public long get_FileOffset() { }

	[CompilerGenerated]
	public int get_FrameLength() { }

	[CompilerGenerated]
	public MpegLayer get_MpegLayer() { }

	[CompilerGenerated]
	public MpegVersion get_MpegVersion() { }

	[CompilerGenerated]
	public Byte[] get_RawData() { }

	[CompilerGenerated]
	public int get_SampleCount() { }

	[CompilerGenerated]
	public int get_SampleRate() { }

	private static bool IsValidHeader(Byte[] headerBytes, Mp3Frame frame) { }

	public static Mp3Frame LoadFromStream(Stream input, bool readData) { }

	public static Mp3Frame LoadFromStream(Stream input) { }

	[CompilerGenerated]
	private void set_BitRate(int value) { }

	[CompilerGenerated]
	private void set_BitRateIndex(int value) { }

	[CompilerGenerated]
	private void set_ChannelExtension(int value) { }

	[CompilerGenerated]
	private void set_ChannelMode(ChannelMode value) { }

	[CompilerGenerated]
	private void set_Copyright(bool value) { }

	[CompilerGenerated]
	private void set_CrcPresent(bool value) { }

	[CompilerGenerated]
	private void set_FileOffset(long value) { }

	[CompilerGenerated]
	private void set_FrameLength(int value) { }

	[CompilerGenerated]
	private void set_MpegLayer(MpegLayer value) { }

	[CompilerGenerated]
	private void set_MpegVersion(MpegVersion value) { }

	[CompilerGenerated]
	private void set_RawData(Byte[] value) { }

	[CompilerGenerated]
	private void set_SampleCount(int value) { }

	[CompilerGenerated]
	private void set_SampleRate(int value) { }

}

