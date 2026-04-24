namespace System.Net.NetworkInformation;

internal struct sockaddr_in6
{
	public ushort sin6_family; //Field offset: 0x0
	public ushort sin6_port; //Field offset: 0x2
	public uint sin6_flowinfo; //Field offset: 0x4
	public in6_addr sin6_addr; //Field offset: 0x8
	public uint sin6_scope_id; //Field offset: 0x10

}

