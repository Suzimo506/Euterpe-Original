namespace NVorbis;

internal class VorbisMode
{
	private VorbisStreamDecoder _vorbis; //Field offset: 0x10
	private Single[][] _windows; //Field offset: 0x18
	internal bool BlockFlag; //Field offset: 0x20
	internal int WindowType; //Field offset: 0x24
	internal int TransformType; //Field offset: 0x28
	internal VorbisMapping Mapping; //Field offset: 0x30
	internal int BlockSize; //Field offset: 0x38

	private VorbisMode(VorbisStreamDecoder vorbis) { }

	private void CalcWindows() { }

	internal Single[] GetWindow(bool prev, bool next) { }

	internal static VorbisMode Init(VorbisStreamDecoder vorbis, DataPacket packet) { }

}

