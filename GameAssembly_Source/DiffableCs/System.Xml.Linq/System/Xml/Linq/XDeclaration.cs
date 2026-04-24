namespace System.Xml.Linq;

public class XDeclaration
{
	private string version; //Field offset: 0x10
	private string encoding; //Field offset: 0x18
	private string standalone; //Field offset: 0x20

	public string Encoding
	{
		 get { } //Length: 5
	}

	public string Standalone
	{
		 get { } //Length: 5
	}

	public string Version
	{
		 get { } //Length: 5
	}

	public XDeclaration(string version, string encoding, string standalone) { }

	public XDeclaration(XDeclaration other) { }

	public string get_Encoding() { }

	public string get_Standalone() { }

	public string get_Version() { }

	public virtual string ToString() { }

}

