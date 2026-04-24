namespace System.Xml;

internal class Base64Decoder : IncrementalReadDecoder
{
	private static readonly string CharsBase64; //Field offset: 0x0
	private static readonly Byte[] MapBase64; //Field offset: 0x8
	private Byte[] buffer; //Field offset: 0x10
	private int startIndex; //Field offset: 0x18
	private int curIndex; //Field offset: 0x1C
	private int endIndex; //Field offset: 0x20
	private int bits; //Field offset: 0x24
	private int bitsFilled; //Field offset: 0x28

	internal virtual int DecodedCount
	{
		internal get { } //Length: 7
	}

	internal virtual bool IsFull
	{
		internal get { } //Length: 10
	}

	private static Base64Decoder() { }

	public Base64Decoder() { }

	private static Byte[] ConstructMapBase64() { }

	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	internal virtual int Decode(string str, int startPos, int len) { }

	private void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, out int charsDecoded, out int bytesDecoded) { }

	internal virtual int get_DecodedCount() { }

	internal virtual bool get_IsFull() { }

	internal virtual void Reset() { }

	internal virtual void SetNextOutputBuffer(Array buffer, int index, int count) { }

}

