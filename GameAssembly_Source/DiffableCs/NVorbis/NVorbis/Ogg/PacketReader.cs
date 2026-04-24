namespace NVorbis.Ogg;

[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class PacketReader : IPacketProvider, IDisposable
{
	private class DebugView
	{
		private PacketReader _reader; //Field offset: 0x10
		private Packet _last; //Field offset: 0x18
		private Packet _first; //Field offset: 0x20
		private Packet[] _packetList; //Field offset: 0x28

		public ContainerReader Container
		{
			 get { } //Length: 27
		}

		public int CurrentPacketIndex
		{
			 get { } //Length: 370
		}

		public bool EndOfStreamFound
		{
			 get { } //Length: 27
		}

		public Packet[] Packets
		{
			 get { } //Length: 263
		}

		public int StreamSerial
		{
			 get { } //Length: 26
		}

		public DebugView(PacketReader reader) { }

		public ContainerReader get_Container() { }

		public int get_CurrentPacketIndex() { }

		public bool get_EndOfStreamFound() { }

		public Packet[] get_Packets() { }

		public int get_StreamSerial() { }

	}

	private EventHandler<ParameterChangeEventArgs> ParameterChange; //Field offset: 0x10
	private ContainerReader _container; //Field offset: 0x18
	private int _streamSerial; //Field offset: 0x20
	private bool _eosFound; //Field offset: 0x24
	private Packet _first; //Field offset: 0x28
	private Packet _current; //Field offset: 0x30
	private Packet _last; //Field offset: 0x38
	private object _packetLock; //Field offset: 0x40
	[CompilerGenerated]
	private long <ContainerBits>k__BackingField; //Field offset: 0x48

	public override event EventHandler<ParameterChangeEventArgs> ParameterChange
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public override bool CanSeek
	{
		 get { } //Length: 48
	}

	public override long ContainerBits
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	internal bool HasEndOfStream
	{
		internal get { } //Length: 5
	}

	public override int StreamSerial
	{
		 get { } //Length: 4
	}

	internal PacketReader(ContainerReader container, int streamSerial) { }

	public override void add_ParameterChange(EventHandler<ParameterChangeEventArgs> value) { }

	internal void AddPacket(Packet packet) { }

	public override void Dispose() { }

	public override DataPacket FindPacket(long granulePos, Func<DataPacket, DataPacket, Int32> packetGranuleCountCallback) { }

	private Packet FindPacketInPage(Packet pagePacket, long targetGranulePos, Func<DataPacket, DataPacket, Int32> packetGranuleCountCallback) { }

	public override bool get_CanSeek() { }

	[CompilerGenerated]
	public override long get_ContainerBits() { }

	internal bool get_HasEndOfStream() { }

	public override int get_StreamSerial() { }

	public override long GetGranuleCount() { }

	internal DataPacket GetLastPacket() { }

	private Packet GetLastPacketInPage(Packet packet) { }

	public override DataPacket GetNextPacket() { }

	public override DataPacket GetPacket(int packetIndex) { }

	public override DataPacket PeekNextPacket() { }

	private Packet PeekNextPacketInternal() { }

	internal void ReadAllPages() { }

	public override void remove_ParameterChange(EventHandler<ParameterChangeEventArgs> value) { }

	public override void SeekToPacket(DataPacket packet, int preRoll) { }

	[CompilerGenerated]
	public void set_ContainerBits(long value) { }

	internal void SetEndOfStream() { }

}

