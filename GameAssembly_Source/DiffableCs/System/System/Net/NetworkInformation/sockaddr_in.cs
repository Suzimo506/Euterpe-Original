namespace System.Net.NetworkInformation;

internal struct sockaddr_in
{
	public ushort sin_family; //Field offset: 0x0
	public ushort sin_port; //Field offset: 0x2
	public uint sin_addr; //Field offset: 0x4

}

