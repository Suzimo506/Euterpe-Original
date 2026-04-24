namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
internal class NativeRingBuffer : IDisposable
{
	private readonly NativeBuffer hqOEUoEDRGnmPYVrQYVmOmLBMjLC; //Field offset: 0x10
	private readonly int fHFzqBypypzEdxCsGjiRCvUHhtXo; //Field offset: 0x18
	private long APtpKArCqTaGCbNgPsHiKxLvSLSD; //Field offset: 0x20
	private long VWbZilCbcWinOAhUzisnBlOHOllvB; //Field offset: 0x28
	private int XxADDVbNCgLoqtbJNJlHAMWnXuPNA; //Field offset: 0x30
	private bool vCXjoyNrKtYxtkxBrhQWaTJNteDc; //Field offset: 0x34
	private uint iAFxTeHmQpLxplGCiBcQWFjZEATDA; //Field offset: 0x38
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x3C

	public bool BufferOverrun
	{
		 get { } //Length: 5
	}

	public int BytesInBuffer
	{
		 get { } //Length: 4
	}

	public int Capacity
	{
		 get { } //Length: 4
	}

	public int ReadPosition
	{
		 get { } //Length: 4
	}

	public long WritePosition
	{
		 get { } //Length: 5
	}

	public NativeRingBuffer(int unnamed_param_0) { }

	public IntPtr Allocate(int bufferLength, bool zeroFill, out uint passId) { }

	public void CopyFrom(NativeRingBuffer other) { }

	protected void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public bool get_BufferOverrun() { }

	public int get_BytesInBuffer() { }

	public int get_Capacity() { }

	public int get_ReadPosition() { }

	public long get_WritePosition() { }

	public int GetOffsetFromReadPosition(int offset) { }

	public IntPtr GetPointerFromReadPosition(int offset) { }

	private void HTPhdvTKDuQckbkQkrCChCQsCKrB() { }

	public bool IsValid(int startIndex, uint passId) { }

	private void jPPCeYkYQBnoUqIPtwLjPzScEqUu(int unnamed_param_0) { }

	private void LdNmzjFnzbHqurfufjmRSNvbQeZs(int unnamed_param_0) { }

	public int RandomRead(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex) { }

	public int RandomRead(Byte[] buffer, int numBytesToRead, int readStartIndex) { }

	public int Read(Byte[] buffer, int numBytesToRead) { }

	public int Read(IntPtr buffer, int bufferLength, int numBytesToRead) { }

	public void Reset() { }

	public int Write(Byte[] buffer, int numBytesToWrite, out int startOffset, out uint passId) { }

	public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite, out int startOffset, out uint passId) { }

	public int Write(Byte[] buffer, int numBytesToWrite) { }

	public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite) { }

}

