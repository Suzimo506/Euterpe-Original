namespace UnityEngine.UIElements;

public struct Length : IEquatable<Length>
{
	private float m_Value; //Field offset: 0x0
	private LengthUnit m_Unit; //Field offset: 0x4

	public LengthUnit unit
	{
		 get { } //Length: 6
	}

	public float value
	{
		 get { } //Length: 7
	}

	public Length(float value) { }

	public Length(float value, LengthUnit unit) { }

	public override bool Equals(Length other) { }

	public virtual bool Equals(object obj) { }

	public LengthUnit get_unit() { }

	public float get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Length lhs, Length rhs) { }

	public virtual string ToString() { }

}

