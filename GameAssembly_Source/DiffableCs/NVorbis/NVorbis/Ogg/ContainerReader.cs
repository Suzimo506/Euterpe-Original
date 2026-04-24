namespace NVorbis.Ogg;

public class ContainerReader : IContainerReader, IDisposable
{
	private class PageHeader
	{
		[CompilerGenerated]
		private int <StreamSerial>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private PageFlags <Flags>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private long <GranulePosition>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private int <SequenceNumber>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private long <DataOffset>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Int32[] <PacketSizes>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private bool <LastPacketContinues>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private bool <IsResync>k__BackingField; //Field offset: 0x39

		public long DataOffset
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public PageFlags Flags
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public long GranulePosition
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public bool IsResync
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool LastPacketContinues
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public Int32[] PacketSizes
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public int SequenceNumber
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public int StreamSerial
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public PageHeader() { }

		[CompilerGenerated]
		public long get_DataOffset() { }

		[CompilerGenerated]
		public PageFlags get_Flags() { }

		[CompilerGenerated]
		public long get_GranulePosition() { }

		[CompilerGenerated]
		public bool get_IsResync() { }

		[CompilerGenerated]
		public bool get_LastPacketContinues() { }

		[CompilerGenerated]
		public Int32[] get_PacketSizes() { }

		[CompilerGenerated]
		public int get_SequenceNumber() { }

		[CompilerGenerated]
		public int get_StreamSerial() { }

		[CompilerGenerated]
		public void set_DataOffset(long value) { }

		[CompilerGenerated]
		public void set_Flags(PageFlags value) { }

		[CompilerGenerated]
		public void set_GranulePosition(long value) { }

		[CompilerGenerated]
		public void set_IsResync(bool value) { }

		[CompilerGenerated]
		public void set_LastPacketContinues(bool value) { }

		[CompilerGenerated]
		public void set_PacketSizes(Int32[] value) { }

		[CompilerGenerated]
		public void set_SequenceNumber(int value) { }

		[CompilerGenerated]
		public void set_StreamSerial(int value) { }

	}

	private Crc _crc; //Field offset: 0x10
	private BufferedReadStream _stream; //Field offset: 0x18
	private Dictionary<Int32, PacketReader> _packetReaders; //Field offset: 0x20
	private List<Int32> _disposedStreamSerials; //Field offset: 0x28
	private long _nextPageOffset; //Field offset: 0x30
	private int _pageCount; //Field offset: 0x38
	private Byte[] _readBuffer; //Field offset: 0x40
	private long _containerBits; //Field offset: 0x48
	private long _wasteBits; //Field offset: 0x50
	private EventHandler<NewStreamEventArgs> NewStream; //Field offset: 0x58

	public override event EventHandler<NewStreamEventArgs> NewStream
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public override bool CanSeek
	{
		 get { } //Length: 39
	}

	public override Int32[] StreamSerials
	{
		 get { } //Length: 82
	}

	public ContainerReader(Stream stream, bool closeOnDispose) { }

	public override void add_NewStream(EventHandler<NewStreamEventArgs> value) { }

	private bool AddPage(PageHeader hdr) { }

	public override void Dispose() { }

	internal void DisposePacketReader(PacketReader packetReader) { }

	private PageHeader FindNextPageHeader() { }

	public override bool FindNextStream() { }

	private int GatherNextPage() { }

	internal void GatherNextPage(int streamSerial) { }

	public override bool get_CanSeek() { }

	public override Int32[] get_StreamSerials() { }

	public override bool Init() { }

	internal void PacketDiscardThrough(long offset) { }

	internal int PacketReadByte(long offset) { }

	private PageHeader ReadPageHeader(long position) { }

	public override void remove_NewStream(EventHandler<NewStreamEventArgs> value) { }

}

