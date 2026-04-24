namespace System;

internal struct NUInt
{
	private readonly Void* _value; //Field offset: 0x0

	private NUInt(uint value) { }

	private NUInt(ulong value) { }

	public static NUInt op_Explicit(int value) { }

	public static Void* op_Explicit(NUInt value) { }

	public static NUInt op_Multiply(NUInt left, NUInt right) { }

}

