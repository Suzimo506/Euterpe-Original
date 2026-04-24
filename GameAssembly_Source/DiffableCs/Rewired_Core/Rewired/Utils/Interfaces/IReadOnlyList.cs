namespace Rewired.Utils.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal interface IReadOnlyList
{

	public int Count
	{
		 get { } //Length: 0
	}

	public object Item
	{
		 get { } //Length: 0
	}

	public bool Contains(object value) { }

	public int get_Count() { }

	public object get_Item(int index) { }

	public int IndexOf(object value) { }

}

