namespace Newtonsoft.Json;

[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IArrayPool
{

	public T[] Rent(int minimumLength) { }

	public void Return(T[] array) { }

}

