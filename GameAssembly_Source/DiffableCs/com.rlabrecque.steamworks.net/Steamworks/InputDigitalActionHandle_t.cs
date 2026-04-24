namespace Steamworks;

public struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
{
	public ulong m_InputDigitalActionHandle; //Field offset: 0x0

	public InputDigitalActionHandle_t(ulong value) { }

	public override int CompareTo(InputDigitalActionHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(InputDigitalActionHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y) { }

	public static InputDigitalActionHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(InputDigitalActionHandle_t that) { }

	public static bool op_Inequality(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y) { }

	public virtual string ToString() { }

}

