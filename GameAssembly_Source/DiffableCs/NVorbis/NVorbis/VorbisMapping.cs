namespace NVorbis;

internal abstract class VorbisMapping
{
	public class CouplingStep
	{
		internal int Magnitude; //Field offset: 0x10
		internal int Angle; //Field offset: 0x14

		internal CouplingStep() { }

	}

	private class Mapping0 : VorbisMapping
	{

		internal Mapping0(VorbisStreamDecoder vorbis) { }

		protected virtual void Init(DataPacket packet) { }

	}

	public class Submap
	{
		internal VorbisFloor Floor; //Field offset: 0x10
		internal VorbisResidue Residue; //Field offset: 0x18

		internal Submap() { }

	}

	private VorbisStreamDecoder _vorbis; //Field offset: 0x10
	internal Submap[] Submaps; //Field offset: 0x18
	internal Submap[] ChannelSubmap; //Field offset: 0x20
	internal CouplingStep[] CouplingSteps; //Field offset: 0x28

	protected VorbisMapping(VorbisStreamDecoder vorbis) { }

	internal static VorbisMapping Init(VorbisStreamDecoder vorbis, DataPacket packet) { }

	protected abstract void Init(DataPacket packet) { }

}

