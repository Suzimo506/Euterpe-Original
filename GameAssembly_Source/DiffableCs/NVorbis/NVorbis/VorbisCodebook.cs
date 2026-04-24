namespace NVorbis;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class VorbisCodebook
{
	internal int BookNum; //Field offset: 0x10
	internal int Dimensions; //Field offset: 0x14
	internal int Entries; //Field offset: 0x18
	private Int32[] Lengths; //Field offset: 0x20
	private Single[] LookupTable; //Field offset: 0x28
	internal int MapType; //Field offset: 0x30
	private HuffmanListNode PrefixOverflowTree; //Field offset: 0x38
	private List<HuffmanListNode> PrefixList; //Field offset: 0x40
	private int PrefixBitLength; //Field offset: 0x48
	private int MaxBits; //Field offset: 0x4C

	internal float Item
	{
		internal get { } //Length: 64
	}

	private VorbisCodebook() { }

	private void AddEntry(bool sparse, Int32[] codewords, Int32[] codewordLengths, uint huffCode, int symbol, int count, int len, Int32[] values) { }

	private bool ComputeCodewords(bool sparse, int sortedEntries, Int32[] codewords, Int32[] codewordLengths, Int32[] len, int n, Int32[] values) { }

	internal int DecodeScalar(DataPacket packet) { }

	internal float get_Item(int entry, int dim) { }

	internal static VorbisCodebook Init(VorbisStreamDecoder vorbis, DataPacket packet, int number) { }

	internal void Init(DataPacket packet) { }

	private void InitLookupTable(DataPacket packet) { }

	private void InitTree(DataPacket packet) { }

	private int lookup1_values() { }

}

