namespace PeroPeroGames;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PeroString : IEnumerable<Char>, IEnumerable
{
	public const int DefaultExpPrecision = 6; //Field offset: 0x0
	private static UInt64[] s_MantissaBitsTable; //Field offset: 0x0
	public const double MaxRoundtripVal = 1.79769313486231E+308; //Field offset: 0x0
	public const double MinRoundtripVal = -1.79769313486231E+308; //Field offset: 0x0
	public const int TenPowersListLength = 19; //Field offset: 0x0
	public const int DecimalDefPrecision = 100; //Field offset: 0x0
	public const int UInt64DefPrecision = 20; //Field offset: 0x0
	public const int Int64DefPrecision = 19; //Field offset: 0x0
	public const int Int32DefPrecision = 10; //Field offset: 0x0
	public const int DoubleDefPrecision = 15; //Field offset: 0x0
	public const int UInt32DefPrecision = 10; //Field offset: 0x0
	public const int DecimalBitsScaleMask = 2031616; //Field offset: 0x0
	public const long DoubleBitsMantissaMask = 4503599627370495; //Field offset: 0x0
	public const int DoubleBitsExponentMask = 2047; //Field offset: 0x0
	public const int DoubleBitsExponentShift = 52; //Field offset: 0x0
	public const ulong ULongModHundredMillion = 9551616; //Field offset: 0x0
	public const ulong ULongDivHundredMillion = 184467440737; //Field offset: 0x0
	public const long SeventeenDigitsThreshold = 10000000000000000; //Field offset: 0x0
	public const int HundredMillion = 100000000; //Field offset: 0x0
	public const int SingleDefPrecision = 7; //Field offset: 0x0
	private static Int32[] s_TensExponentTable; //Field offset: 0x8
	private static Int64[] s_TenPowerList; //Field offset: 0x10
	private static Int32[] s_DecHexDigits; //Field offset: 0x18
	private int m_BufferLength; //Field offset: 0x10
	private int m_Length; //Field offset: 0x14
	private string m_StrBuffer; //Field offset: 0x18

	public int bufferLength
	{
		 get { } //Length: 4
	}

	public char Item
	{
		 get { } //Length: 30
	}

	public int length
	{
		 get { } //Length: 4
	}

	private static PeroString() { }

	public PeroString(int length) { }

	public PeroString Append(string str) { }

	public PeroString Append(int value) { }

	private bool CheckOut(int length) { }

	public PeroString Clear() { }

	public bool Contains(string value) { }

	public int get_bufferLength() { }

	public char get_Item(int index) { }

	public int get_length() { }

	public override IEnumerator<Char> GetEnumerator() { }

	private void IntegerToString(int value) { }

	public static string op_Implicit(PeroString pStr) { }

	public PeroString Resize(int length) { }

	private void SetChar(int index, char c) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public PeroString ToLower() { }

	private static char ToLowerAsciiInvariant(char c) { }

	public virtual string ToString() { }

}

