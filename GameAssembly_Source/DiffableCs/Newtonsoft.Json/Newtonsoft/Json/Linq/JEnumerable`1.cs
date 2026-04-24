namespace Newtonsoft.Json.Linq;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
[IsReadOnly]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct JEnumerable : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable`1<T>>
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly JEnumerable<T> Empty; //Field offset: 0x0
	private readonly IEnumerable<T> _enumerable; //Field offset: 0x0

	private static JEnumerable`1() { }

	public JEnumerable`1(IEnumerable<T> enumerable) { }

	public override bool Equals(JEnumerable<T> other) { }

	public virtual bool Equals(object obj) { }

	public override IEnumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

