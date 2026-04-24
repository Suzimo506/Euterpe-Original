namespace Steamworks;

public struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
{
	public ulong m_InputActionSetHandle; //Field offset: 0x0

	public InputActionSetHandle_t(ulong value) { }

	public override int CompareTo(InputActionSetHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(InputActionSetHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(InputActionSetHandle_t x, InputActionSetHandle_t y) { }

	public static InputActionSetHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(InputActionSetHandle_t that) { }

	public static bool op_Inequality(InputActionSetHandle_t x, InputActionSetHandle_t y) { }

	public virtual string ToString() { }

}

