namespace NVorbis;

internal abstract class VorbisFloor
{
	private class Floor0 : VorbisFloor
	{
		private class PacketData0 : PacketData
		{
			internal Single[] Coeff; //Field offset: 0x18
			internal float Amp; //Field offset: 0x20

			protected virtual bool HasEnergy
			{
				 get { } //Length: 15
			}

			public PacketData0() { }

			protected virtual bool get_HasEnergy() { }

		}

		private int _order; //Field offset: 0x18
		private int _rate; //Field offset: 0x1C
		private int _bark_map_size; //Field offset: 0x20
		private int _ampBits; //Field offset: 0x24
		private int _ampOfs; //Field offset: 0x28
		private int _ampDiv; //Field offset: 0x2C
		private VorbisCodebook[] _books; //Field offset: 0x30
		private int _bookBits; //Field offset: 0x38
		private Dictionary<Int32, Single[]> _wMap; //Field offset: 0x40
		private Dictionary<Int32, Int32[]> _barkMaps; //Field offset: 0x48
		private PacketData0[] _reusablePacketData; //Field offset: 0x50

		internal Floor0(VorbisStreamDecoder vorbis) { }

		internal virtual void Apply(PacketData packetData, Single[] residue) { }

		protected virtual void Init(DataPacket packet) { }

		private Int32[] SynthesizeBarkCurve(int n) { }

		private Single[] SynthesizeWDelMap(int n) { }

		private static float toBARK(double lsp) { }

		internal virtual PacketData UnpackPacket(DataPacket packet, int blockSize, int channel) { }

	}

	private class Floor1 : VorbisFloor
	{
		private class PacketData1 : PacketData
		{
			public Int32[] Posts; //Field offset: 0x18
			public int PostCount; //Field offset: 0x20

			protected virtual bool HasEnergy
			{
				 get { } //Length: 8
			}

			public PacketData1() { }

			protected virtual bool get_HasEnergy() { }

		}

		private static Int32[] _rangeLookup; //Field offset: 0x0
		private static Int32[] _yBitsLookup; //Field offset: 0x8
		private static readonly Single[] inverse_dB_table; //Field offset: 0x10
		private Int32[] _partitionClass; //Field offset: 0x18
		private Int32[] _classDimensions; //Field offset: 0x20
		private Int32[] _classSubclasses; //Field offset: 0x28
		private Int32[] _xList; //Field offset: 0x30
		private Int32[] _classMasterBookIndex; //Field offset: 0x38
		private Int32[] _hNeigh; //Field offset: 0x40
		private Int32[] _lNeigh; //Field offset: 0x48
		private Int32[] _sortIdx; //Field offset: 0x50
		private int _multiplier; //Field offset: 0x58
		private int _range; //Field offset: 0x5C
		private int _yBits; //Field offset: 0x60
		private VorbisCodebook[] _classMasterbooks; //Field offset: 0x68
		private VorbisCodebook[][] _subclassBooks; //Field offset: 0x70
		private Int32[][] _subclassBookIndex; //Field offset: 0x78
		private PacketData1[] _reusablePacketData; //Field offset: 0x80
		private Boolean[] _stepFlags; //Field offset: 0x88
		private Int32[] _finalY; //Field offset: 0x90

		private static Floor1() { }

		internal Floor1(VorbisStreamDecoder vorbis) { }

		internal virtual void Apply(PacketData packetData, Single[] residue) { }

		protected virtual void Init(DataPacket packet) { }

		private void RenderLineMulti(int x0, int y0, int x1, int y1, Single[] v) { }

		private int RenderPoint(int x0, int y0, int x1, int y1, int X) { }

		internal virtual PacketData UnpackPacket(DataPacket packet, int blockSize, int channel) { }

		private Boolean[] UnwrapPosts(PacketData1 data) { }

	}

	public abstract class PacketData
	{
		internal int BlockSize; //Field offset: 0x10
		[CompilerGenerated]
		private bool <ForceEnergy>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private bool <ForceNoEnergy>k__BackingField; //Field offset: 0x15

		internal bool ExecuteChannel
		{
			internal get { } //Length: 56
		}

		internal bool ForceEnergy
		{
			[CompilerGenerated]
			internal get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 4
		}

		internal bool ForceNoEnergy
		{
			[CompilerGenerated]
			internal get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 4
		}

		protected abstract bool HasEnergy
		{
			 get { } //Length: 0
		}

		protected PacketData() { }

		internal bool get_ExecuteChannel() { }

		[CompilerGenerated]
		internal bool get_ForceEnergy() { }

		[CompilerGenerated]
		internal bool get_ForceNoEnergy() { }

		protected abstract bool get_HasEnergy() { }

		[CompilerGenerated]
		internal void set_ForceEnergy(bool value) { }

		[CompilerGenerated]
		internal void set_ForceNoEnergy(bool value) { }

	}

	private VorbisStreamDecoder _vorbis; //Field offset: 0x10

	protected VorbisFloor(VorbisStreamDecoder vorbis) { }

	internal abstract void Apply(PacketData packetData, Single[] residue) { }

	internal static VorbisFloor Init(VorbisStreamDecoder vorbis, DataPacket packet) { }

	protected abstract void Init(DataPacket packet) { }

	internal abstract PacketData UnpackPacket(DataPacket packet, int blockSize, int channel) { }

}

