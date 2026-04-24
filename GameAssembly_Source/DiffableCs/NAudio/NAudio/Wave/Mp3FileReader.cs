namespace NAudio.Wave;

public class Mp3FileReader : WaveStream
{
	internal sealed class FrameDecompressorBuilder : MulticastDelegate
	{

		public FrameDecompressorBuilder(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(WaveFormat mp3Format, AsyncCallback callback, object object) { }

		public override IMp3FrameDecompressor EndInvoke(IAsyncResult result) { }

		public override IMp3FrameDecompressor Invoke(WaveFormat mp3Format) { }

	}

	private readonly WaveFormat waveFormat; //Field offset: 0x28
	private Stream mp3Stream; //Field offset: 0x30
	private readonly long mp3DataLength; //Field offset: 0x38
	private readonly long dataStartPosition; //Field offset: 0x40
	private readonly Id3v2Tag id3v2Tag; //Field offset: 0x48
	private readonly XingHeader xingHeader; //Field offset: 0x50
	private readonly Byte[] id3v1Tag; //Field offset: 0x58
	private readonly bool ownInputStream; //Field offset: 0x60
	private List<Mp3Index> tableOfContents; //Field offset: 0x68
	private int tocIndex; //Field offset: 0x70
	private long totalSamples; //Field offset: 0x78
	private readonly int bytesPerSample; //Field offset: 0x80
	private readonly int bytesPerDecodedFrame; //Field offset: 0x84
	private IMp3FrameDecompressor decompressor; //Field offset: 0x88
	private readonly Byte[] decompressBuffer; //Field offset: 0x90
	private int decompressBufferOffset; //Field offset: 0x98
	private int decompressLeftovers; //Field offset: 0x9C
	private bool repositionedFlag; //Field offset: 0xA0
	private long position; //Field offset: 0xA8
	private readonly object repositionLock; //Field offset: 0xB0
	[CompilerGenerated]
	private Mp3WaveFormat <Mp3WaveFormat>k__BackingField; //Field offset: 0xB8

	public virtual long Length
	{
		 get { } //Length: 13
	}

	public private Mp3WaveFormat Mp3WaveFormat
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public virtual long Position
	{
		 get { } //Length: 8
		 set { } //Length: 598
	}

	public virtual WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public Mp3FileReader(Stream inputStream) { }

	public Mp3FileReader(Stream inputStream, FrameDecompressorBuilder frameDecompressorBuilder) { }

	public static IMp3FrameDecompressor CreateAcmFrameDecompressor(WaveFormat mp3Format) { }

	private void CreateTableOfContents() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual long get_Length() { }

	[CompilerGenerated]
	public Mp3WaveFormat get_Mp3WaveFormat() { }

	public virtual long get_Position() { }

	public virtual WaveFormat get_WaveFormat() { }

	public virtual int Read(Byte[] sampleBuffer, int offset, int numBytes) { }

	public Mp3Frame ReadNextFrame() { }

	private Mp3Frame ReadNextFrame(bool readData) { }

	[CompilerGenerated]
	private void set_Mp3WaveFormat(Mp3WaveFormat value) { }

	public virtual void set_Position(long value) { }

	private double TotalSeconds() { }

	private void ValidateFrameFormat(Mp3Frame frame) { }

}

