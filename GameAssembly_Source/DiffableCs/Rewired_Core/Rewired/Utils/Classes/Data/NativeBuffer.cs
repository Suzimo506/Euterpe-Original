namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class NativeBuffer : IDisposable
{
	private IntPtr ODFlHkcCjsQNZQqgCZTsNvOFtAGt; //Field offset: 0x10
	private int afoOuVuAILpkpaTPOTAsalvWdwas; //Field offset: 0x18
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x1C

	public byte Item
	{
		 get { } //Length: 148
		 set { } //Length: 166
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public IntPtr Pointer
	{
		 get { } //Length: 5
	}

	public NativeBuffer(int unnamed_param_0) { }

	public void Clear() { }

	public static bool Copy(NativeBuffer source, NativeBuffer destination) { }

	public void CopyFrom(NativeBuffer other) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public string DumpToHexString() { }

	protected virtual void Finalize() { }

	public byte get_Item(int index) { }

	public int get_Length() { }

	public IntPtr get_Pointer() { }

	public IntPtr GetPointer(int offset = 0) { }

	public static IntPtr op_Implicit(NativeBuffer buffer) { }

	public void Read(Byte[] buffer, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	public void Read(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	public bool ReadBit(int byteIndex, byte bit) { }

	public byte ReadByte(int startIndex) { }

	public double ReadDouble(int startIndex) { }

	public float ReadFloat(int startIndex) { }

	public int ReadInt(int startIndex) { }

	public long ReadLong(int startIndex) { }

	public short ReadShort(int startIndex) { }

	public uint ReadUInt(int startIndex) { }

	public ulong ReadULong(int startIndex) { }

	public ushort ReadUShort(int startIndex) { }

	public void Release() { }

	public bool Resize(int size, bool preserveData) { }

	public void set_Item(int index, byte value) { }

	public virtual string ToString() { }

	public int TryFill(byte value, int numBytesToWrite, int writeStartIndex = 0) { }

	public int TryReadBytes(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	public int TryReadBytes(Byte[] buffer, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	public int TryWriteBytes(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	public int TryWriteBytes(Byte[] bytes, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	public void Write(ulong bytes, int startIndex) { }

	public void Write(Byte[] bytes, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	public void Write(double bytes, int startIndex) { }

	public void Write(float bytes, int startIndex) { }

	public void Write(long bytes, int startIndex) { }

	public void Write(uint bytes, int startIndex) { }

	public void Write(int bytes, int startIndex) { }

	public void Write(ushort bytes, int startIndex) { }

	public void Write(short bytes, int startIndex) { }

	public void Write(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	public void Write(byte byte, int startIndex) { }

	public void WriteBit(int byteIndex, byte bit, bool value) { }

}

