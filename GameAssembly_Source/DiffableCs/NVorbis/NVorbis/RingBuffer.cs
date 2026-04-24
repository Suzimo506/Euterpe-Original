namespace NVorbis;

internal class RingBuffer
{
	private Single[] _buffer; //Field offset: 0x10
	private int _start; //Field offset: 0x18
	private int _end; //Field offset: 0x1C
	private int _bufLen; //Field offset: 0x20
	internal int Channels; //Field offset: 0x24

	internal int Length
	{
		internal get { } //Length: 12
	}

	internal RingBuffer(int size) { }

	internal void Clear() { }

	internal void CopyTo(Single[] buffer, int index, int count) { }

	internal void EnsureSize(int size) { }

	internal int get_Length() { }

	internal void RemoveItems(int count) { }

	internal void Write(int channel, int index, int start, int switchPoint, int end, Single[] pcm, Single[] window) { }

}

