namespace NVorbis;

internal abstract class VorbisResidue
{
	private class Residue0 : VorbisResidue
	{
		private int _begin; //Field offset: 0x20
		private int _end; //Field offset: 0x24
		private int _partitionSize; //Field offset: 0x28
		private int _classifications; //Field offset: 0x2C
		private int _maxStages; //Field offset: 0x30
		private VorbisCodebook[][] _books; //Field offset: 0x38
		private VorbisCodebook _classBook; //Field offset: 0x40
		private Int32[] _cascade; //Field offset: 0x48
		private Int32[] _entryCache; //Field offset: 0x50
		private Int32[][] _decodeMap; //Field offset: 0x58
		private Int32[][][] _partWordCache; //Field offset: 0x60

		internal Residue0(VorbisStreamDecoder vorbis) { }

		internal virtual Single[][] Decode(DataPacket packet, Boolean[] doNotDecode, int channels, int blockSize) { }

		protected virtual void Init(DataPacket packet) { }

		protected override bool WriteVectors(VorbisCodebook codebook, DataPacket packet, Single[][] residue, int channel, int offset, int partitionSize) { }

	}

	private class Residue1 : Residue0
	{

		internal Residue1(VorbisStreamDecoder vorbis) { }

		protected virtual bool WriteVectors(VorbisCodebook codebook, DataPacket packet, Single[][] residue, int channel, int offset, int partitionSize) { }

	}

	private class Residue2 : Residue0
	{
		private int _channels; //Field offset: 0x68

		internal Residue2(VorbisStreamDecoder vorbis) { }

		internal virtual Single[][] Decode(DataPacket packet, Boolean[] doNotDecode, int channels, int blockSize) { }

		protected virtual bool WriteVectors(VorbisCodebook codebook, DataPacket packet, Single[][] residue, int channel, int offset, int partitionSize) { }

	}

	private VorbisStreamDecoder _vorbis; //Field offset: 0x10
	private Single[][] _residue; //Field offset: 0x18

	protected VorbisResidue(VorbisStreamDecoder vorbis) { }

	internal abstract Single[][] Decode(DataPacket packet, Boolean[] doNotDecode, int channels, int blockSize) { }

	protected Single[][] GetResidueBuffer(int channels) { }

	private static int icount(int v) { }

	internal static VorbisResidue Init(VorbisStreamDecoder vorbis, DataPacket packet) { }

	protected abstract void Init(DataPacket packet) { }

}

