namespace System.Net.NetworkInformation.MacOsStructs;

internal struct sockaddr_in
{
	public byte sin_len; //Field offset: 0x0
	public byte sin_family; //Field offset: 0x1
	public ushort sin_port; //Field offset: 0x2
	public uint sin_addr; //Field offset: 0x4

}

