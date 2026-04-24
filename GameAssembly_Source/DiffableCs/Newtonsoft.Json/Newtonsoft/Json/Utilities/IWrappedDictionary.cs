namespace Newtonsoft.Json.Utilities;

internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
{

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object UnderlyingDictionary
	{
		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 0
	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object get_UnderlyingDictionary() { }

}

