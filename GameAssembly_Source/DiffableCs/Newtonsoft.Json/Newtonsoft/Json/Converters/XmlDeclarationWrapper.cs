namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
{
	private readonly XmlDeclaration _declaration; //Field offset: 0x28

	public override string Encoding
	{
		 get { } //Length: 27
	}

	public override string Standalone
	{
		 get { } //Length: 27
	}

	public override string Version
	{
		 get { } //Length: 27
	}

	public XmlDeclarationWrapper(XmlDeclaration declaration) { }

	public override string get_Encoding() { }

	public override string get_Standalone() { }

	public override string get_Version() { }

}

