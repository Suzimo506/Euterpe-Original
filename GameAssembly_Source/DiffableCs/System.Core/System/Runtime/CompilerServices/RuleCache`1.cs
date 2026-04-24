namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class RuleCache
{
	private T[] _rules; //Field offset: 0x0
	private readonly object _cacheLock; //Field offset: 0x0

	internal RuleCache`1() { }

	private static T[] AddOrInsert(T[] rules, T item) { }

	internal void AddRule(T newRule) { }

	internal T[] GetRules() { }

	internal void MoveRule(T rule, int i) { }

}

