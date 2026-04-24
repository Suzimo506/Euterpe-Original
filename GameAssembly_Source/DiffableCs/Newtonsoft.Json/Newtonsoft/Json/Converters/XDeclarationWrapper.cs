namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
{
	[CompilerGenerated]
	private readonly XDeclaration <Declaration>k__BackingField; //Field offset: 0x18

	internal XDeclaration Declaration
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public override string Encoding
	{
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public override string Standalone
	{
		 get { } //Length: 27
	}

	public override string Version
	{
		 get { } //Length: 27
	}

	public XDeclarationWrapper(XDeclaration declaration) { }

	[CompilerGenerated]
	internal XDeclaration get_Declaration() { }

	public override string get_Encoding() { }

	public virtual XmlNodeType get_NodeType() { }

	public override string get_Standalone() { }

	public override string get_Version() { }

}

