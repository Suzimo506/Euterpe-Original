namespace System.Net.NetworkInformation;

internal class Win32NetworkInterface2 : NetworkInterface
{
	private Win32_IP_ADAPTER_ADDRESSES addr; //Field offset: 0x10
	private Win32_MIB_IFROW mib4; //Field offset: 0x118
	private Win32_MIB_IFROW mib6; //Field offset: 0x188
	private Win32IPv4InterfaceStatistics ip4stats; //Field offset: 0x1F8
	private IPInterfaceProperties ip_if_props; //Field offset: 0x200

	public virtual string Description
	{
		 get { } //Length: 5
	}

	internal Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr) { }

	public virtual string get_Description() { }

	private static int GetIfEntry(ref Win32_MIB_IFROW row) { }

	public virtual PhysicalAddress GetPhysicalAddress() { }

}

