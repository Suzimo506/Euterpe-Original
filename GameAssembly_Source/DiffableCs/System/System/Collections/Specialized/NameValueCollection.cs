namespace System.Collections.Specialized;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NameValueCollection : NameObjectCollectionBase
{
	private String[] _all; //Field offset: 0x58
	private String[] _allKeys; //Field offset: 0x60

	public override String[] AllKeys
	{
		 get { } //Length: 289
	}

	public string Item
	{
		 get { } //Length: 17
		 set { } //Length: 17
	}

	public NameValueCollection() { }

	public NameValueCollection(int capacity) { }

	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	internal NameValueCollection(DBNull dummy) { }

	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	public override void Add(string name, string value) { }

	public override string Get(int index) { }

	public override string Get(string name) { }

	public override String[] get_AllKeys() { }

	public string get_Item(string name) { }

	private static string GetAsOneString(ArrayList list) { }

	private static String[] GetAsStringArray(ArrayList list) { }

	public override string GetKey(int index) { }

	public override String[] GetValues(string name) { }

	public override String[] GetValues(int index) { }

	protected void InvalidateCachedArrays() { }

	public override void Remove(string name) { }

	public override void Set(string name, string value) { }

	public void set_Item(string name, string value) { }

}

