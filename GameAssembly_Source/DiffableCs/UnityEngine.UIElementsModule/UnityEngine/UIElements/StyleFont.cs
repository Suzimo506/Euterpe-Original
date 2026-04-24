namespace UnityEngine.UIElements;

public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private Font m_Value; //Field offset: 0x8
	private int m_Specificity; //Field offset: 0x10

	public override StyleKeyword keyword
	{
		 get { } //Length: 5
	}

	public override Font value
	{
		 get { } //Length: 13
	}

	public override bool Equals(StyleFont other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Font get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	public virtual string ToString() { }

}

