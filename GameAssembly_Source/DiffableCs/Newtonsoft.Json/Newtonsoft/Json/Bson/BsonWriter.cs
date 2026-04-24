namespace Newtonsoft.Json.Bson;

[Obsolete]
public class BsonWriter : JsonWriter
{
	private BsonToken _root; //Field offset: 0x60
	private BsonToken _parent; //Field offset: 0x68
	private string _propertyName; //Field offset: 0x70

	internal void AddToken(BsonToken token) { }

	private void AddValue(object value, BsonType type) { }

	public void WriteObjectId(Byte[] value) { }

	public void WriteRegex(string pattern, string options) { }

}

