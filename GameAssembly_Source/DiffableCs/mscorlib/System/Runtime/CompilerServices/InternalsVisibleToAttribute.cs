namespace System.Runtime.CompilerServices;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName; //Field offset: 0x10
	private bool _allInternalsVisible; //Field offset: 0x18

	public bool AllInternalsVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string AssemblyName
	{
		 get { } //Length: 5
	}

	public InternalsVisibleToAttribute(string assemblyName) { }

	public bool get_AllInternalsVisible() { }

	public string get_AssemblyName() { }

	public void set_AllInternalsVisible(bool value) { }

}

