namespace ProtoBuf.Meta;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class MutableList : BasicList
{

	public object Item
	{
		 get { } //Length: 30
		 set { } //Length: 225
	}

	public MutableList() { }

	public void Clear() { }

	public object get_Item(int index) { }

	public void RemoveLast() { }

	public void set_Item(int index, object value) { }

}

