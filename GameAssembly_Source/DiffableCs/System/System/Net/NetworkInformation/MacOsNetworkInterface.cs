namespace System.Net.NetworkInformation;

internal sealed class MacOsNetworkInterface : UnixNetworkInterface
{
	private uint _ifa_flags; //Field offset: 0x30

	internal MacOsNetworkInterface(string name, uint ifa_flags) { }

}

