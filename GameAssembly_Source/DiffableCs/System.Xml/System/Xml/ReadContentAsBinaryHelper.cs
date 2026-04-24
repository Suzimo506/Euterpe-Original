namespace System.Xml;

internal class ReadContentAsBinaryHelper
{
	private enum State
	{
		None = 0,
		InReadContent = 1,
		InReadElementContent = 2,
	}

	private XmlReader reader; //Field offset: 0x10
	private State state; //Field offset: 0x18
	private int valueOffset; //Field offset: 0x1C
	private bool isEnd; //Field offset: 0x20
	private bool canReadValueChunk; //Field offset: 0x21
	private Char[] valueChunk; //Field offset: 0x28
	private int valueChunkLength; //Field offset: 0x30
	private IncrementalReadDecoder decoder; //Field offset: 0x38
	private Base64Decoder base64Decoder; //Field offset: 0x40
	private BinHexDecoder binHexDecoder; //Field offset: 0x48

	internal ReadContentAsBinaryHelper(XmlReader reader) { }

	internal static ReadContentAsBinaryHelper CreateOrReset(ReadContentAsBinaryHelper helper, XmlReader reader) { }

	internal void Finish() { }

	private bool Init() { }

	private void InitBase64Decoder() { }

	private void InitBinHexDecoder() { }

	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	internal int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	private int ReadContentAsBinary(Byte[] buffer, int index, int count) { }

	internal int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	internal void Reset() { }

}

