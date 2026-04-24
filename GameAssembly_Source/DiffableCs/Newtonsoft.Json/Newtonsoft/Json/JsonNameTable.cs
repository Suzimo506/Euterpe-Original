namespace Newtonsoft.Json;

public abstract class JsonNameTable
{

	protected JsonNameTable() { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public abstract string Get(Char[] key, int start, int length) { }

}

