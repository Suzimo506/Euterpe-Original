namespace System.Net.NetworkInformation;

internal abstract class UnixNetworkInterface : NetworkInterface
{
	private string name; //Field offset: 0x10
	protected List<IPAddress> addresses; //Field offset: 0x18
	private Byte[] macAddress; //Field offset: 0x20
	private NetworkInterfaceType type; //Field offset: 0x28

	public virtual string Description
	{
		 get { } //Length: 5
	}

	internal UnixNetworkInterface(string name) { }

	internal void AddAddress(IPAddress address) { }

	public virtual string get_Description() { }

	public virtual PhysicalAddress GetPhysicalAddress() { }

	internal void SetLinkLayerInfo(int index, Byte[] macAddress, NetworkInterfaceType type) { }

}

