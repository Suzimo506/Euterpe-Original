namespace System;

[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct UIntPtr : ISerializable
{
	public static readonly UIntPtr Zero; //Field offset: 0x0
	private Void* _pointer; //Field offset: 0x0

	public static int Size
	{
		 get { } //Length: 6
	}

	private static UIntPtr() { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public UIntPtr(Void* value) { }

	public UIntPtr(ulong value) { }

	public UIntPtr(uint value) { }

	public virtual bool Equals(object obj) { }

	public static int get_Size() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	public static ulong op_Explicit(UIntPtr value) { }

	public static uint op_Explicit(UIntPtr value) { }

	public static UIntPtr op_Explicit(ulong value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static UIntPtr op_Explicit(Void* value) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Void* op_Explicit(UIntPtr value) { }

	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	public static UIntPtr op_Subtraction(UIntPtr pointer, int offset) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Void* ToPointer() { }

	public virtual string ToString() { }

}

