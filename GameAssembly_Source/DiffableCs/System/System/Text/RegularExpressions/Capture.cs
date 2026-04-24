namespace System.Text.RegularExpressions;

public class Capture
{
	internal string _text; //Field offset: 0x10
	internal int _index; //Field offset: 0x18
	internal int _length; //Field offset: 0x1C

	public int Index
	{
		 get { } //Length: 4
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public string Value
	{
		 get { } //Length: 40
	}

	internal Capture(string text, int i, int l) { }

	internal Capture() { }

	public int get_Index() { }

	public int get_Length() { }

	public string get_Value() { }

	internal string GetLeftSubstring() { }

	internal string GetOriginalString() { }

	internal string GetRightSubstring() { }

	public virtual string ToString() { }

}

