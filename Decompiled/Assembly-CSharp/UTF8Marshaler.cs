using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

[Token(Token = "0x2000076")]
public class UTF8Marshaler : ICustomMarshaler
{
	[Token(Token = "0x4000328")]
	private static UTF8Marshaler instance_;

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x4E94E0", Offset = "0x4E7CE0", Length = "0x158")]
	public IntPtr MarshalManagedToNative(object obj)
	{
		return default(IntPtr);
	}

	[Address(RVA = "0x4E9640", Offset = "0x4E7E40", Length = "0x10D")]
	[Token(Token = "0x600038B")]
	public object MarshalNativeToManaged(IntPtr data)
	{
		return null;
	}

	[Address(RVA = "0x4E93F0", Offset = "0x4E7BF0", Length = "0x51")]
	[Token(Token = "0x600038C")]
	public void CleanUpNativeData(IntPtr data)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600038D")]
	public void CleanUpManagedData(object obj)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x4E94D0", Offset = "0x4E7CD0", Length = "0x6")]
	public int GetNativeDataSize()
	{
		return default(int);
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x4E9450", Offset = "0x4E7C50", Length = "0x72")]
	public static ICustomMarshaler GetInstance(string cookie)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x4E9750", Offset = "0x4E7F50", Length = "0x10C")]
	public static string MarshalNativeToString(IntPtr data)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public UTF8Marshaler()
	{
	}
}
