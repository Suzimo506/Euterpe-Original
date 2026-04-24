namespace System.Xml;

internal abstract class IncrementalReadDecoder
{

	internal abstract int DecodedCount
	{
		internal get { } //Length: 0
	}

	internal abstract bool IsFull
	{
		internal get { } //Length: 0
	}

	protected IncrementalReadDecoder() { }

	internal abstract int Decode(Char[] chars, int startPos, int len) { }

	internal abstract int Decode(string str, int startPos, int len) { }

	internal abstract int get_DecodedCount() { }

	internal abstract bool get_IsFull() { }

	internal abstract void Reset() { }

	internal abstract void SetNextOutputBuffer(Array array, int offset, int len) { }

}

