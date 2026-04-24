namespace Newtonsoft.Json.Bson;

internal class BsonObject : BsonToken
{
	private readonly List<BsonProperty> _children; //Field offset: 0x18

	public virtual BsonType Type
	{
		 get { } //Length: 3
	}

	public void Add(string name, BsonToken token) { }

	public virtual BsonType get_Type() { }

}

