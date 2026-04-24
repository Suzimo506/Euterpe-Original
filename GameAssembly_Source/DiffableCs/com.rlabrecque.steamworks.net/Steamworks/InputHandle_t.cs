namespace Steamworks;

public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
{
	public ulong m_InputHandle; //Field offset: 0x0

	public InputHandle_t(ulong value) { }

	public override int CompareTo(InputHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(InputHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(InputHandle_t x, InputHandle_t y) { }

	public static InputHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(InputHandle_t that) { }

	public static bool op_Inequality(InputHandle_t x, InputHandle_t y) { }

	public virtual string ToString() { }

}

