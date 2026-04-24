namespace System.Resources;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	private string _culture; //Field offset: 0x10
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x18

	public string CultureName
	{
		 get { } //Length: 5
	}

	public UltimateResourceFallbackLocation Location
	{
		 get { } //Length: 4
	}

	public NeutralResourcesLanguageAttribute(string cultureName) { }

	public string get_CultureName() { }

	public UltimateResourceFallbackLocation get_Location() { }

}

