namespace System;

[IsReadOnly]
public struct SequencePosition : IEquatable<SequencePosition>
{
	private readonly object _object; //Field offset: 0x0
	private readonly int _integer; //Field offset: 0x8

	public SequencePosition(object object, int integer) { }

	public override bool Equals(SequencePosition other) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual bool Equals(object obj) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual int GetHashCode() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int GetInteger() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public object GetObject() { }

}

