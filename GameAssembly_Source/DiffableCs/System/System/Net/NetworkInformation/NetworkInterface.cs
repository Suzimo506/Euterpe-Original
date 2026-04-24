namespace System.Net.NetworkInformation;

public abstract class NetworkInterface
{

	public override string Description
	{
		 get { } //Length: 73
	}

	protected NetworkInterface() { }

	public override string get_Description() { }

	public static NetworkInterface[] GetAllNetworkInterfaces() { }

	public override PhysicalAddress GetPhysicalAddress() { }

}

