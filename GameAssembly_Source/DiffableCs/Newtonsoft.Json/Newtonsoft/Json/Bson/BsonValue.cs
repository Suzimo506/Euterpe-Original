namespace Newtonsoft.Json.Bson;

internal class BsonValue : BsonToken
{
	private readonly object _value; //Field offset: 0x18
	private readonly BsonType _type; //Field offset: 0x20

	public virtual BsonType Type
	{
		 get { } //Length: 5
	}

	public BsonValue(object value, BsonType type) { }

	public virtual BsonType get_Type() { }

}

