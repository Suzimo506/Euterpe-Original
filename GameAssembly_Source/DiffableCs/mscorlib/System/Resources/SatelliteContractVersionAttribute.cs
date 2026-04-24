namespace System.Resources;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	private string _version; //Field offset: 0x10

	public string Version
	{
		 get { } //Length: 5
	}

	public SatelliteContractVersionAttribute(string version) { }

	public string get_Version() { }

}

