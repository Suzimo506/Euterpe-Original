namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class ValueType
{
	private static class Internal
	{
		public static int hash_code_of_ptr_seed; //Field offset: 0x2C927BC

	}


	protected ValueType() { }

	internal static bool DefaultEquals(object o1, object o2) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	internal static int GetHashCodeOfPtr(IntPtr ptr) { }

	private static bool InternalEquals(object o1, object o2, out Object[] fields) { }

	internal static int InternalGetHashCode(object o, out Object[] fields) { }

	public virtual string ToString() { }

}

