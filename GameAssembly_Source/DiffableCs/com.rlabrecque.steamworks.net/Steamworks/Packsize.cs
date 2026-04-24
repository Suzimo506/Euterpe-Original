namespace Steamworks;

public static class Packsize
{
	private struct ValvePackingSentinel_t
	{
		private uint m_u32; //Field offset: 0x0
		private ulong m_u64; //Field offset: 0x8
		private ushort m_u16; //Field offset: 0x10
		private double m_d; //Field offset: 0x18

	}

	public const int value = 8; //Field offset: 0x0

	public static bool Test() { }

}

