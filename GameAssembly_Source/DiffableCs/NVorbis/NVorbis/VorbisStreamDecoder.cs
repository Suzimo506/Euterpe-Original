namespace NVorbis;

internal class VorbisStreamDecoder : IVorbisStreamStatus, IDisposable
{
	internal int _upperBitrate; //Field offset: 0x10
	internal int _nominalBitrate; //Field offset: 0x14
	internal int _lowerBitrate; //Field offset: 0x18
	internal string _vendor; //Field offset: 0x20
	internal String[] _comments; //Field offset: 0x28
	internal int _channels; //Field offset: 0x30
	internal int _sampleRate; //Field offset: 0x34
	internal int Block0Size; //Field offset: 0x38
	internal int Block1Size; //Field offset: 0x3C
	internal VorbisCodebook[] Books; //Field offset: 0x40
	internal VorbisTime[] Times; //Field offset: 0x48
	internal VorbisFloor[] Floors; //Field offset: 0x50
	internal VorbisResidue[] Residues; //Field offset: 0x58
	internal VorbisMapping[] Maps; //Field offset: 0x60
	internal VorbisMode[] Modes; //Field offset: 0x68
	private int _modeFieldBits; //Field offset: 0x70
	internal long _glueBits; //Field offset: 0x78
	internal long _metaBits; //Field offset: 0x80
	internal long _bookBits; //Field offset: 0x88
	internal long _timeHdrBits; //Field offset: 0x90
	internal long _floorHdrBits; //Field offset: 0x98
	internal long _resHdrBits; //Field offset: 0xA0
	internal long _mapHdrBits; //Field offset: 0xA8
	internal long _modeHdrBits; //Field offset: 0xB0
	internal long _wasteHdrBits; //Field offset: 0xB8
	internal long _modeBits; //Field offset: 0xC0
	internal long _floorBits; //Field offset: 0xC8
	internal long _resBits; //Field offset: 0xD0
	internal long _wasteBits; //Field offset: 0xD8
	internal long _samples; //Field offset: 0xE0
	internal int _packetCount; //Field offset: 0xE8
	internal Stopwatch _sw; //Field offset: 0xF0
	private IPacketProvider _packetProvider; //Field offset: 0xF8
	private DataPacket _parameterChangePacket; //Field offset: 0x100
	private List<Int32> _pagesSeen; //Field offset: 0x108
	private int _lastPageSeen; //Field offset: 0x110
	private bool _eosFound; //Field offset: 0x114
	private object _seekLock; //Field offset: 0x118
	private Single[] _prevBuffer; //Field offset: 0x120
	private RingBuffer _outputBuffer; //Field offset: 0x128
	private Queue<Int32> _bitsPerPacketHistory; //Field offset: 0x130
	private Queue<Int32> _sampleCountHistory; //Field offset: 0x138
	private int _preparedLength; //Field offset: 0x140
	internal bool _clipped; //Field offset: 0x144
	private Stack<DataPacket> _resyncQueue; //Field offset: 0x148
	private long _currentPosition; //Field offset: 0x150
	private long _reportedPosition; //Field offset: 0x158
	private VorbisMode _mode; //Field offset: 0x160
	private bool _prevFlag; //Field offset: 0x168
	private bool _nextFlag; //Field offset: 0x169
	private Boolean[] _noExecuteChannel; //Field offset: 0x170
	private PacketData[] _floorData; //Field offset: 0x178
	private Single[][] _residue; //Field offset: 0x180
	private bool _isParameterChange; //Field offset: 0x188

	internal bool CanSeek
	{
		internal get { } //Length: 75
	}

	internal long ContainerBits
	{
		internal get { } //Length: 75
	}

	internal long CurrentPosition
	{
		internal get { } //Length: 8
		private set { } //Length: 76
	}

	internal bool IsParameterChange
	{
		internal get { } //Length: 8
		internal set { } //Length: 114
	}

	internal VorbisStreamDecoder(IPacketProvider packetProvider) { }

	private void DecodeNextPacket() { }

	private void DecodePacket() { }

	public override void Dispose() { }

	internal bool get_CanSeek() { }

	internal long get_ContainerBits() { }

	internal long get_CurrentPosition() { }

	internal bool get_IsParameterChange() { }

	internal long GetLastGranulePos() { }

	internal int GetPacketLength(DataPacket curPacket, DataPacket lastPacket) { }

	private void InitDecoder() { }

	private bool LoadBooks(DataPacket packet) { }

	private bool LoadComments(DataPacket packet) { }

	private int OverlapSamples() { }

	private void ProcessParameterChange(DataPacket packet) { }

	private bool ProcessStreamHeader(DataPacket packet) { }

	internal int ReadSamples(Single[] buffer, int offset, int count) { }

	private void ResetDecoder(bool isFullReset) { }

	private void SaveBuffer() { }

	internal void SeekTo(long granulePos) { }

	private void set_CurrentPosition(long value) { }

	internal void set_IsParameterChange(bool value) { }

	private void SetParametersChanging(object sender, ParameterChangeEventArgs e) { }

	internal bool TryInit() { }

	private bool UnpackPacket(DataPacket packet) { }

	private void UpdatePosition(int samplesDecoded, DataPacket packet) { }

}

