namespace PeroTools2.Commons;

public class Integer2String
{
	private static readonly Char[] s_NumStrings; //Field offset: 0x0
	private const int int_max_length = 11; //Field offset: 0x0
	private readonly string m_Buffer; //Field offset: 0x10
	private readonly string m_Output; //Field offset: 0x18
	private readonly Char[][] m_CharArrays; //Field offset: 0x20
	private readonly Int32[] m_Indexs; //Field offset: 0x28
	private readonly List<Int32> m_Positions; //Field offset: 0x30

	private static Integer2String() { }

	public Integer2String(int maxLength = 11, string format = null) { }

	private static void Change(string s, int index, char c) { }

	public void SetText(Text text, Int32[] numbers) { }

	public string ToString(Int32[] numbers) { }

}

