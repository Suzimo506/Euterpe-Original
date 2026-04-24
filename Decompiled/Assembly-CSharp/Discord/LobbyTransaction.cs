using System;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200042F")]
public struct LobbyTransaction
{
	[Token(Token = "0x2000AD6")]
	internal struct FFIMethods
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E1B")]
		internal delegate Result SetTypeMethod(IntPtr methodsPtr, LobbyType type);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E1C")]
		internal delegate Result SetOwnerMethod(IntPtr methodsPtr, long ownerId);

		[Token(Token = "0x2000E1D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result SetCapacityMethod(IntPtr methodsPtr, uint capacity);

		[Token(Token = "0x2000E1E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

		[Token(Token = "0x2000E1F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

		[Token(Token = "0x2000E20")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result SetLockedMethod(IntPtr methodsPtr, bool locked);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038AB")]
		internal SetTypeMethod SetType;

		[Token(Token = "0x40038AC")]
		[FieldOffset(Offset = "0x8")]
		internal SetOwnerMethod SetOwner;

		[Token(Token = "0x40038AD")]
		[FieldOffset(Offset = "0x10")]
		internal SetCapacityMethod SetCapacity;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40038AE")]
		internal SetMetadataMethod SetMetadata;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40038AF")]
		internal DeleteMetadataMethod DeleteMetadata;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40038B0")]
		internal SetLockedMethod SetLocked;
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001746")]
	internal IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001747")]
	internal object MethodsStructure;

	[Token(Token = "0x1700046F")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x21B5B80", Offset = "0x21B4380", Length = "0x10D")]
		[Token(Token = "0x6003147")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x6003148")]
	[Address(RVA = "0x21B5AD0", Offset = "0x21B42D0", Length = "0xAC")]
	public void SetType(LobbyType type)
	{
	}

	[Address(RVA = "0x21B5A20", Offset = "0x21B4220", Length = "0xAE")]
	[Token(Token = "0x6003149")]
	public void SetOwner(long ownerId)
	{
	}

	[Token(Token = "0x600314A")]
	[Address(RVA = "0x21B57F0", Offset = "0x21B3FF0", Length = "0xAD")]
	public void SetCapacity(uint capacity)
	{
	}

	[Token(Token = "0x600314B")]
	[Address(RVA = "0x21B5950", Offset = "0x21B4150", Length = "0xC3")]
	public void SetMetadata(string key, string value)
	{
	}

	[Address(RVA = "0x21B5740", Offset = "0x21B3F40", Length = "0xAE")]
	[Token(Token = "0x600314C")]
	public void DeleteMetadata(string key)
	{
	}

	[Address(RVA = "0x21B58A0", Offset = "0x21B40A0", Length = "0xAF")]
	[Token(Token = "0x600314D")]
	public void SetLocked(bool locked)
	{
	}
}
