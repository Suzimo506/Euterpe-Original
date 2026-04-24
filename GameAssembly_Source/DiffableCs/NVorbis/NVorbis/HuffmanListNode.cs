namespace NVorbis;

internal class HuffmanListNode
{
	internal int Value; //Field offset: 0x10
	internal int Length; //Field offset: 0x14
	internal int Bits; //Field offset: 0x18
	internal int Mask; //Field offset: 0x1C
	internal HuffmanListNode Next; //Field offset: 0x20

	public HuffmanListNode() { }

}

