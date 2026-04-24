namespace Newtonsoft.Json.Bson;

internal abstract class BsonToken
{
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; //Field offset: 0x10

	public BsonToken Parent
	{
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public abstract BsonType Type
	{
		 get { } //Length: 0
	}

	protected BsonToken() { }

	public abstract BsonType get_Type() { }

	[CompilerGenerated]
	public void set_Parent(BsonToken value) { }

}

