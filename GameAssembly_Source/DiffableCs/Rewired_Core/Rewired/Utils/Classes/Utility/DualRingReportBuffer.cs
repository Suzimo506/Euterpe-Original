namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal class DualRingReportBuffer : IDisposable
{
	private readonly int pOkugkzcfdJoksmvEsDiPmFOGyPH; //Field offset: 0x10
	private readonly int bJFSZOtjmbAjwXdsaJePLiFZFkOgA; //Field offset: 0x14
	private readonly int uJGGEBiptskZNyvrndOJyzasCQei; //Field offset: 0x18
	private NativeRingBuffer kVQaCnDvrJapSBSaARTzbBebzfUZb; //Field offset: 0x20
	private NativeRingBuffer NehknpHoqCvtqwYnxokioajHudtX; //Field offset: 0x28
	private Byte[] DziFLlhxGaxEswKdjJlTQdFZxQgm; //Field offset: 0x30
	private Byte[] EbZiVanEayeJgHDifmmgBVNHRjQEc; //Field offset: 0x38
	private int pMGNlmvmIUNwoWstBEVhDTcCfpfN; //Field offset: 0x40
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x44

	public int BufferLength
	{
		 get { } //Length: 4
	}

	public int BytesInBuffer
	{
		 get { } //Length: 26
	}

	public int EntriesInBuffer
	{
		 get { } //Length: 30
	}

	public int LastNumBytesRead
	{
		 get { } //Length: 4
	}

	public Byte[] ReadBuffer
	{
		 get { } //Length: 5
	}

	public DualRingReportBuffer(int unnamed_param_0, int unnamed_param_1) { }

	public void Clear() { }

	private void crurRRcvvOsOgegFTYAxeiHNsJMQ() { }

	protected void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public int get_BufferLength() { }

	public int get_BytesInBuffer() { }

	public int get_EntriesInBuffer() { }

	public int get_LastNumBytesRead() { }

	public Byte[] get_ReadBuffer() { }

	public int Read() { }

	public int Read(IntPtr buffer, int bufferLength, int numBytesToRead) { }

	public int Read(Byte[] buffer, int numBytesToRead) { }

	public int StartRead() { }

	public int Write(Byte[] buffer, int numBytesToWrite) { }

	public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite) { }

}

