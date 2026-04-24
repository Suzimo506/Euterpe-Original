using System;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000430")]
public struct LobbyMemberTransaction
{
	[Token(Token = "0x2000AD7")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E21")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E22")]
		internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038B1")]
		internal SetMetadataMethod SetMetadata;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40038B2")]
		internal DeleteMetadataMethod DeleteMetadata;
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001748")]
	internal IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001749")]
	internal object MethodsStructure;

	[Token(Token = "0x17000470")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x21B5210", Offset = "0x21B3A10", Length = "0xFD")]
		[Token(Token = "0x600314E")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Address(RVA = "0x21B5150", Offset = "0x21B3950", Length = "0xBA")]
	[Token(Token = "0x600314F")]
	public void SetMetadata(string key, string value)
	{
	}

	[Token(Token = "0x6003150")]
	[Address(RVA = "0x21B50A0", Offset = "0x21B38A0", Length = "0xA5")]
	public void DeleteMetadata(string key)
	{
	}
}
