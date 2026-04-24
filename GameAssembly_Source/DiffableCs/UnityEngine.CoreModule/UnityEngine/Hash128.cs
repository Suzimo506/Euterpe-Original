namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
	private uint m_u32_0; //Field offset: 0x0
	private uint m_u32_1; //Field offset: 0x4
	private uint m_u32_2; //Field offset: 0x8
	private uint m_u32_3; //Field offset: 0xC

	public bool isValid
	{
		 get { } //Length: 29
	}

	internal ulong u64_0
	{
		internal get { } //Length: 6
	}

	internal ulong u64_1
	{
		internal get { } //Length: 7
	}

	public Hash128(ulong u64_0, ulong u64_1) { }

	public override int CompareTo(object obj) { }

	public override int CompareTo(Hash128 rhs) { }

	[FreeFunction]
	public static Hash128 Compute(string hashString) { }

	private static void Compute_Injected(string hashString, out Hash128 ret) { }

	public override bool Equals(Hash128 obj) { }

	public virtual bool Equals(object obj) { }

	public bool get_isValid() { }

	internal ulong get_u64_0() { }

	internal ulong get_u64_1() { }

	public virtual int GetHashCode() { }

	[FreeFunction]
	internal static string Internal_Hash128ToString(Hash128 hash128) { }

	private static string Internal_Hash128ToString_Injected(ref Hash128 hash128) { }

	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	[FreeFunction]
	public static Hash128 Parse(string hashString) { }

	private static void Parse_Injected(string hashString, out Hash128 ret) { }

	public virtual string ToString() { }

}

