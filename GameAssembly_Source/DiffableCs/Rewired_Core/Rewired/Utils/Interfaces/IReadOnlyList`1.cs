namespace Rewired.Utils.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal interface IReadOnlyList : IReadOnlyList
{

	public T Item
	{
		 get { } //Length: 0
	}

	public bool Contains(T value) { }

	public T get_Item(int index) { }

	public int IndexOf(T value) { }

}

