namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
{
	private readonly XmlDocument _document; //Field offset: 0x28

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IXmlElement DocumentElement
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 161
	}

	public XmlDocumentWrapper(XmlDocument document) { }

	public override IXmlNode CreateAttribute(string name, string value) { }

	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	public override IXmlNode CreateCDataSection(string data) { }

	public override IXmlNode CreateComment(string data) { }

	public override IXmlElement CreateElement(string elementName) { }

	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	public override IXmlNode CreateSignificantWhitespace(string text) { }

	public override IXmlNode CreateTextNode(string text) { }

	public override IXmlNode CreateWhitespace(string text) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IXmlElement get_DocumentElement() { }

}

