namespace Newtonsoft.Json.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsReadOnly]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal struct StringReference
{
	private readonly Char[] _chars; //Field offset: 0x0
	private readonly int _startIndex; //Field offset: 0x8
	private readonly int _length; //Field offset: 0xC

	public Char[] Chars
	{
		 get { } //Length: 4
	}

	public char Item
	{
		 get { } //Length: 53
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public int StartIndex
	{
		 get { } //Length: 4
	}

	public StringReference(Char[] chars, int startIndex, int length) { }

	public Char[] get_Chars() { }

	public char get_Item(int i) { }

	public int get_Length() { }

	public int get_StartIndex() { }

	public virtual string ToString() { }

}

