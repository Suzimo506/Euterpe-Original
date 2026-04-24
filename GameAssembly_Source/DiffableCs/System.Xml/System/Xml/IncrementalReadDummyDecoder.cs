namespace System.Xml;

internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
{

	internal virtual int DecodedCount
	{
		internal get { } //Length: 6
	}

	internal virtual bool IsFull
	{
		internal get { } //Length: 3
	}

	public IncrementalReadDummyDecoder() { }

	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	internal virtual int Decode(string str, int startPos, int len) { }

	internal virtual int get_DecodedCount() { }

	internal virtual bool get_IsFull() { }

	internal virtual void Reset() { }

	internal virtual void SetNextOutputBuffer(Array array, int offset, int len) { }

}

