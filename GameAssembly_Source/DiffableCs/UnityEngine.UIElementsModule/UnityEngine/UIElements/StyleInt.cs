namespace UnityEngine.UIElements;

public struct StyleInt : IStyleValue<Int32>, IEquatable<StyleInt>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private int m_Value; //Field offset: 0x4
	private int m_Specificity; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		 get { } //Length: 5
	}

	internal int specificity
	{
		internal get { } //Length: 6
	}

	public override int value
	{
		 get { } //Length: 12
	}

	public StyleInt(int v) { }

	internal StyleInt(int v, StyleKeyword keyword) { }

	public override bool Equals(StyleInt other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	internal int get_specificity() { }

	public override int get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	public static StyleInt op_Implicit(int v) { }

	public virtual string ToString() { }

}

