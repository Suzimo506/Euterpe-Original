namespace Newtonsoft.Json.Converters;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal interface IXmlElement : IXmlNode
{

	public bool IsEmpty
	{
		 get { } //Length: 0
	}

	public bool get_IsEmpty() { }

	public string GetPrefixOfNamespace(string namespaceUri) { }

	public void SetAttributeNode(IXmlNode attribute) { }

}

