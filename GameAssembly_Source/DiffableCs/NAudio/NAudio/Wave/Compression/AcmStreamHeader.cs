namespace NAudio.Wave.Compression;

internal class AcmStreamHeader : IDisposable
{
	private AcmStreamHeaderStruct streamHeader; //Field offset: 0x10
	private Byte[] sourceBuffer; //Field offset: 0x18
	private GCHandle hSourceBuffer; //Field offset: 0x20
	private Byte[] destBuffer; //Field offset: 0x28
	private GCHandle hDestBuffer; //Field offset: 0x30
	private IntPtr streamHandle; //Field offset: 0x38
	private bool firstTime; //Field offset: 0x40
	private bool disposed; //Field offset: 0x41

	public Byte[] DestBuffer
	{
		 get { } //Length: 5
	}

	public Byte[] SourceBuffer
	{
		 get { } //Length: 5
	}

	public AcmStreamHeader(IntPtr streamHandle, int sourceBufferLength, int destBufferLength) { }

	public int Convert(int bytesToConvert, out int sourceBytesConverted) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public Byte[] get_DestBuffer() { }

	public Byte[] get_SourceBuffer() { }

	private void Prepare() { }

	public void Reposition() { }

	private void Unprepare() { }

}

