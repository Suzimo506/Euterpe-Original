namespace System;

[Extension]
public static class TypeExtensions
{
	private static readonly Dictionary<Type, TypeCode> TypeCodeMap; //Field offset: 0x6A160

	private static TypeExtensions() { }

	[Extension]
	public static TypeCode GetTypeCode(object obj) { }

	[Extension]
	public static TypeCode ToTypeCode(Type type) { }

}

