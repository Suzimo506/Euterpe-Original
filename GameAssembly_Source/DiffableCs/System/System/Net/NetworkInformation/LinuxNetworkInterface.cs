namespace System.Net.NetworkInformation;

internal sealed class LinuxNetworkInterface : UnixNetworkInterface
{
	private string iface_path; //Field offset: 0x30
	private string iface_operstate_path; //Field offset: 0x38
	private string iface_flags_path; //Field offset: 0x40

	internal string IfacePath
	{
		internal get { } //Length: 5
	}

	internal LinuxNetworkInterface(string name) { }

	internal string get_IfacePath() { }

}

