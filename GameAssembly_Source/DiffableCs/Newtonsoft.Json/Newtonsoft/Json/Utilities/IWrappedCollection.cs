namespace Newtonsoft.Json.Utilities;

internal interface IWrappedCollection : IList, ICollection, IEnumerable
{

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object UnderlyingCollection
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 0
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object get_UnderlyingCollection() { }

}

