namespace NVorbis;

public abstract class DataPacket
{
	[Flags]
	internal enum PacketFlags
	{
		IsResync = 1,
		IsEndOfStream = 2,
		IsShort = 4,
		HasGranuleCount = 8,
		User1 = 16,
		User2 = 32,
		User3 = 64,
		User4 = 128,
	}

	private ulong _bitBucket; //Field offset: 0x10
	private int _bitCount; //Field offset: 0x18
	private int _readBits; //Field offset: 0x1C
	private byte _overflowBits; //Field offset: 0x20
	private PacketFlags _packetFlags; //Field offset: 0x21
	private long _granulePosition; //Field offset: 0x28
	private long _pageGranulePosition; //Field offset: 0x30
	private int _length; //Field offset: 0x38
	private int _granuleCount; //Field offset: 0x3C
	private int _pageSequenceNumber; //Field offset: 0x40

	public long BitsRead
	{
		 get { } //Length: 5
	}

	public Nullable<Int32> GranuleCount
	{
		 get { } //Length: 90
		 set { } //Length: 87
	}

	public long GranulePosition
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public internal bool IsEndOfStream
	{
		 get { } //Length: 9
		internal set { } //Length: 33
	}

	public internal bool IsResync
	{
		 get { } //Length: 7
		internal set { } //Length: 33
	}

	internal bool IsShort
	{
		internal get { } //Length: 10
		private set { } //Length: 33
	}

	public int Length
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public internal long PageGranulePosition
	{
		 get { } //Length: 5
		internal set { } //Length: 5
	}

	internal int PageSequenceNumber
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	protected DataPacket(int length) { }

	public override void Done() { }

	public long get_BitsRead() { }

	public Nullable<Int32> get_GranuleCount() { }

	public long get_GranulePosition() { }

	public bool get_IsEndOfStream() { }

	public bool get_IsResync() { }

	internal bool get_IsShort() { }

	public int get_Length() { }

	public long get_PageGranulePosition() { }

	internal int get_PageSequenceNumber() { }

	protected bool GetFlag(PacketFlags flag) { }

	public bool ReadBit() { }

	public ulong ReadBits(int count) { }

	public byte ReadByte() { }

	public Byte[] ReadBytes(int count) { }

	public int ReadInt32() { }

	protected abstract int ReadNextByte() { }

	public uint ReadUInt32() { }

	protected void ResetBitReader() { }

	public void set_GranuleCount(Nullable<Int32> value) { }

	public void set_GranulePosition(long value) { }

	internal void set_IsEndOfStream(bool value) { }

	internal void set_IsResync(bool value) { }

	private void set_IsShort(bool value) { }

	protected void set_Length(int value) { }

	internal void set_PageGranulePosition(long value) { }

	internal void set_PageSequenceNumber(int value) { }

	protected void SetFlag(PacketFlags flag, bool value) { }

	public void SkipBits(int count) { }

	public ulong TryPeekBits(int count, out int bitsRead) { }

}

