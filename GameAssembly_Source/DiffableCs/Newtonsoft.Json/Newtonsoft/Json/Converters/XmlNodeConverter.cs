namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class XmlNodeConverter : JsonConverter
{
	internal static readonly List<IXmlNode> EmptyChildNodes; //Field offset: 0x0
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string <DeserializeRootElementName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; //Field offset: 0x1A

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string DeserializeRootElementName
	{
		[CompilerGenerated]
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 5
	}

	public bool EncodeSpecialCharacters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool OmitRootObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool WriteArrayAttribute
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static XmlNodeConverter() { }

	public XmlNodeConverter() { }

	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	private static bool AllSameName(IXmlNode node) { }

	public virtual bool CanConvert(Type valueType) { }

	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<String, String> attributeNameValues) { }

	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	[CompilerGenerated]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string get_DeserializeRootElementName() { }

	[CompilerGenerated]
	public bool get_EncodeSpecialCharacters() { }

	[CompilerGenerated]
	public bool get_OmitRootObject() { }

	[CompilerGenerated]
	public bool get_WriteArrayAttribute() { }

	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	private bool IsArray(IXmlNode node) { }

	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	private bool IsXmlNode(Type valueType) { }

	private bool IsXObject(Type valueType) { }

	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	private Dictionary<String, String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	private bool ShouldReadInto(JsonReader reader) { }

	private bool ValueAttributes(List<IXmlNode> c) { }

	private IXmlNode WrapXml(object value) { }

	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

