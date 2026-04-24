namespace Newtonsoft.Json.Converters;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal interface IXmlDocument : IXmlNode
{

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IXmlElement DocumentElement
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 0
	}

	public IXmlNode CreateAttribute(string name, string value) { }

	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	public IXmlNode CreateCDataSection(string data) { }

	public IXmlNode CreateComment(string text) { }

	public IXmlElement CreateElement(string elementName) { }

	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	public IXmlNode CreateSignificantWhitespace(string text) { }

	public IXmlNode CreateTextNode(string text) { }

	public IXmlNode CreateWhitespace(string text) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IXmlElement get_DocumentElement() { }

}

