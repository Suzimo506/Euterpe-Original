namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
{
	private readonly XmlDocumentType _documentType; //Field offset: 0x28

	public override string InternalSubset
	{
		 get { } //Length: 27
	}

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string LocalName
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 43
	}

	public override string Name
	{
		 get { } //Length: 39
	}

	public override string Public
	{
		 get { } //Length: 27
	}

	public override string System
	{
		 get { } //Length: 27
	}

	public XmlDocumentTypeWrapper(XmlDocumentType documentType) { }

	public override string get_InternalSubset() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual string get_LocalName() { }

	public override string get_Name() { }

	public override string get_Public() { }

	public override string get_System() { }

}

