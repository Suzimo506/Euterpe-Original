namespace System.Net.NetworkInformation;

internal struct ifaddrs
{
	public IntPtr ifa_next; //Field offset: 0x0
	public string ifa_name; //Field offset: 0x8
	public uint ifa_flags; //Field offset: 0x10
	public IntPtr ifa_addr; //Field offset: 0x18
	public IntPtr ifa_netmask; //Field offset: 0x20
	public ifa_ifu ifa_ifu; //Field offset: 0x28
	public IntPtr ifa_data; //Field offset: 0x30

}

