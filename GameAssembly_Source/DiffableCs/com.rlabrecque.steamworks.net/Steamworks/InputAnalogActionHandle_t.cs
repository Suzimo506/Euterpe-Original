namespace Steamworks;

public struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t>
{
	public ulong m_InputAnalogActionHandle; //Field offset: 0x0

	public InputAnalogActionHandle_t(ulong value) { }

	public override int CompareTo(InputAnalogActionHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(InputAnalogActionHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y) { }

	public static InputAnalogActionHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(InputAnalogActionHandle_t that) { }

	public static bool op_Inequality(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y) { }

	public virtual string ToString() { }

}

