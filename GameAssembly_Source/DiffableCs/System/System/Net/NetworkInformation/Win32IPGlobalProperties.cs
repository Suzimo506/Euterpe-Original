namespace System.Net.NetworkInformation;

internal class Win32IPGlobalProperties : IPGlobalProperties
{

	public virtual string DomainName
	{
		 get { } //Length: 511
	}

	public Win32IPGlobalProperties() { }

	public virtual string get_DomainName() { }

}

