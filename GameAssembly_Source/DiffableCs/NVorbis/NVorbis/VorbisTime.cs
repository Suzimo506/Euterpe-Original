namespace NVorbis;

internal abstract class VorbisTime
{
	private class Time0 : VorbisTime
	{

		internal Time0(VorbisStreamDecoder vorbis) { }

		protected virtual void Init(DataPacket packet) { }

	}

	private VorbisStreamDecoder _vorbis; //Field offset: 0x10

	protected VorbisTime(VorbisStreamDecoder vorbis) { }

	internal static VorbisTime Init(VorbisStreamDecoder vorbis, DataPacket packet) { }

	protected abstract void Init(DataPacket packet) { }

}

