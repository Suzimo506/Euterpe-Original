namespace Steamworks;

public struct servernetadr_t
{
	private ushort m_usConnectionPort; //Field offset: 0x0
	private ushort m_usQueryPort; //Field offset: 0x2
	private uint m_unIP; //Field offset: 0x4

	public int CompareTo(servernetadr_t other) { }

	public virtual bool Equals(object other) { }

	public bool Equals(servernetadr_t other) { }

	public string GetConnectionAddressString() { }

	public ushort GetConnectionPort() { }

	public virtual int GetHashCode() { }

	public uint GetIP() { }

	public string GetQueryAddressString() { }

	public ushort GetQueryPort() { }

	public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort) { }

	public static bool op_Equality(servernetadr_t x, servernetadr_t y) { }

	public static bool op_GreaterThan(servernetadr_t x, servernetadr_t y) { }

	public static bool op_Inequality(servernetadr_t x, servernetadr_t y) { }

	public static bool op_LessThan(servernetadr_t x, servernetadr_t y) { }

	public void SetConnectionPort(ushort usPort) { }

	public void SetIP(uint unIP) { }

	public void SetQueryPort(ushort usPort) { }

	public static string ToString(uint unIP, ushort usPort) { }

}

