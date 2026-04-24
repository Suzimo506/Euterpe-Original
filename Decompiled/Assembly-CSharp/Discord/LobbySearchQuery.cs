using System;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000431")]
public struct LobbySearchQuery
{
	[Token(Token = "0x2000AD8")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E23")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result FilterMethod(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E24")]
		internal delegate Result SortMethod(IntPtr methodsPtr, string key, LobbySearchCast cast, string value);

		[Token(Token = "0x2000E25")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result LimitMethod(IntPtr methodsPtr, uint limit);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E26")]
		internal delegate Result DistanceMethod(IntPtr methodsPtr, LobbySearchDistance distance);

		[Token(Token = "0x40038B3")]
		[FieldOffset(Offset = "0x0")]
		internal FilterMethod Filter;

		[Token(Token = "0x40038B4")]
		[FieldOffset(Offset = "0x8")]
		internal SortMethod Sort;

		[Token(Token = "0x40038B5")]
		[FieldOffset(Offset = "0x10")]
		internal LimitMethod Limit;

		[Token(Token = "0x40038B6")]
		[FieldOffset(Offset = "0x18")]
		internal DistanceMethod Distance;
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400174A")]
	internal IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400174B")]
	internal object MethodsStructure;

	[Token(Token = "0x17000471")]
	private FFIMethods Methods
	{
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x21B5630", Offset = "0x21B3E30", Length = "0x105")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x6003152")]
	[Address(RVA = "0x21B53C0", Offset = "0x21B3BC0", Length = "0xDF")]
	public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
	{
	}

	[Address(RVA = "0x21B5550", Offset = "0x21B3D50", Length = "0xD6")]
	[Token(Token = "0x6003153")]
	public void Sort(string key, LobbySearchCast cast, string value)
	{
	}

	[Address(RVA = "0x21B54A0", Offset = "0x21B3CA0", Length = "0xA4")]
	[Token(Token = "0x6003154")]
	public void Limit(uint limit)
	{
	}

	[Address(RVA = "0x21B5310", Offset = "0x21B3B10", Length = "0xA4")]
	[Token(Token = "0x6003155")]
	public void Distance(LobbySearchDistance distance)
	{
	}
}
