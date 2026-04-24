namespace UnityEngine.UIElements;

public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private Length m_Value; //Field offset: 0x4
	private int m_Specificity; //Field offset: 0xC

	public override StyleKeyword keyword
	{
		 get { } //Length: 5
	}

	public override Length value
	{
		 get { } //Length: 13
	}

	internal StyleLength(Length v, StyleKeyword keyword) { }

	public override bool Equals(StyleLength other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Length get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	public virtual string ToString() { }

}

