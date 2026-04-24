namespace Antlr.Runtime;

public sealed class BitSet : ICloneable
{
	private const int BITS = 64; //Field offset: 0x0
	private const int LOG_BITS = 6; //Field offset: 0x0
	private const int MOD_MASK = 63; //Field offset: 0x0
	private UInt64[] _bits; //Field offset: 0x10

	public BitSet() { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public BitSet(UInt64[] bits) { }

	public BitSet(IEnumerable<Int32> items) { }

	public BitSet(int nbits) { }

	public void Add(int el) { }

	private static ulong BitMask(int bitNumber) { }

	public override object Clone() { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	public void GrowToInclude(int bit) { }

	public bool IsNil() { }

	public int LengthInLongWords() { }

	public bool Member(int el) { }

	public int NumBits() { }

	private static int NumWordsToHold(int el) { }

	public static BitSet Of(int a, int b) { }

	public static BitSet Of(int a, int b, int c) { }

	public static BitSet Of(int el) { }

	public static BitSet Of(int a, int b, int c, int d) { }

	public BitSet Or(BitSet a) { }

	public void OrInPlace(BitSet a) { }

	public void Remove(int el) { }

	private void SetSize(int nwords) { }

	public int Size() { }

	public Int32[] ToArray() { }

	public virtual string ToString() { }

	public string ToString(String[] tokenNames) { }

	private static int WordNumber(int bit) { }

}

