namespace System.Net.NetworkInformation;

internal abstract class NetworkInterfaceFactory
{
	private class LinuxNetworkInterfaceAPI : UnixNetworkInterfaceAPI
	{

		public LinuxNetworkInterfaceAPI() { }

		private static void FreeInterfaceAddresses(IntPtr ifap) { }

		public virtual NetworkInterface[] GetAllNetworkInterfaces() { }

		private static int GetInterfaceAddresses(out IntPtr ifap) { }

	}

	private class MacOsNetworkInterfaceAPI : UnixNetworkInterfaceAPI
	{

		public MacOsNetworkInterfaceAPI() { }

		public virtual NetworkInterface[] GetAllNetworkInterfaces() { }

	}

	public abstract class UnixNetworkInterfaceAPI : NetworkInterfaceFactory
	{

		protected UnixNetworkInterfaceAPI() { }

		protected static void freeifaddrs(IntPtr ifap) { }

		protected static int getifaddrs(out IntPtr ifap) { }

	}

	private class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
	{

		public Win32NetworkInterfaceAPI() { }

		private static int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size) { }

		private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() { }

		public virtual NetworkInterface[] GetAllNetworkInterfaces() { }

	}


	protected NetworkInterfaceFactory() { }

	public static NetworkInterfaceFactory Create() { }

	public abstract NetworkInterface[] GetAllNetworkInterfaces() { }

}

