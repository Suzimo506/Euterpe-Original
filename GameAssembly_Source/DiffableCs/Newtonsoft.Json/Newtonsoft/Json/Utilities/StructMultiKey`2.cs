namespace Newtonsoft.Json.Utilities;

[IsReadOnly]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal struct StructMultiKey : IEquatable<StructMultiKey`2<T1, T2>>
{
	public readonly T1 Value1; //Field offset: 0x0
	public readonly T2 Value2; //Field offset: 0x0

	public StructMultiKey`2(T1 v1, T2 v2) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(StructMultiKey<T1, T2> other) { }

	public virtual int GetHashCode() { }

}

