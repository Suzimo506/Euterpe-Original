namespace UnityEngine.UIElements;

public struct StyleEnum : IStyleValue<T>, IEquatable<StyleEnum`1<T>>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private T m_Value; //Field offset: 0x0
	private int m_Specificity; //Field offset: 0x0

	public override StyleKeyword keyword
	{
		 get { } //Length: 5
	}

	internal int specificity
	{
		internal set { } //Length: 4
	}

	public override T value
	{
		 get { } //Length: 12
	}

	internal StyleEnum`1(T v, StyleKeyword keyword) { }

	public override bool Equals(StyleEnum<T> other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override T get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	internal void set_specificity(int value) { }

	public virtual string ToString() { }

}

