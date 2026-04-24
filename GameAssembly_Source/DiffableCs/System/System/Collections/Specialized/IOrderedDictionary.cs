namespace System.Collections.Specialized;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable
{

	public object Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public object get_Item(int index) { }

	public IDictionaryEnumerator GetEnumerator() { }

	public void Insert(int index, object key, object value) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, object value) { }

}

