namespace Sirenix.Utilities;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IImmutableList : IImmutableList, IList, IEnumerable, ICollection, IList<T>, ICollection<T>, IEnumerable<T>
{

	public T Item
	{
		 get { } //Length: 0
	}

	public T get_Item(int index) { }

}

