using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000438")]
public class RelationshipManager
{
	[Token(Token = "0x2000AE9")]
	internal struct FFIEvents
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E49")]
		internal delegate void RefreshHandler(IntPtr ptr);

		[Token(Token = "0x2000E4A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038EF")]
		internal RefreshHandler OnRefresh;

		[Token(Token = "0x40038F0")]
		[FieldOffset(Offset = "0x8")]
		internal RelationshipUpdateHandler OnRelationshipUpdate;
	}

	[Token(Token = "0x2000AEA")]
	internal struct FFIMethods
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E4B")]
		internal delegate bool FilterCallback(IntPtr ptr, ref Relationship relationship);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E4C")]
		internal delegate void FilterMethod(IntPtr methodsPtr, IntPtr callbackData, FilterCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E4D")]
		internal delegate Result CountMethod(IntPtr methodsPtr, ref int count);

		[Token(Token = "0x2000E4E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetMethod(IntPtr methodsPtr, long userId, ref Relationship relationship);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E4F")]
		internal delegate Result GetAtMethod(IntPtr methodsPtr, uint index, ref Relationship relationship);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038F1")]
		internal FilterMethod Filter;

		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x8")]
		internal CountMethod Count;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038F3")]
		internal GetMethod Get;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40038F4")]
		internal GetAtMethod GetAt;
	}

	[Token(Token = "0x2000AEB")]
	public delegate bool FilterHandler(ref Relationship relationship);

	[Token(Token = "0x2000AEC")]
	public delegate void RefreshHandler();

	[Token(Token = "0x2000AED")]
	public delegate void RelationshipUpdateHandler(ref Relationship relationship);

	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x17000477")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x21B9B30", Offset = "0x21B8330", Length = "0x106")]
		[Token(Token = "0x600318E")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x14000030")]
	public event RefreshHandler OnRefresh
	{
		[Address(RVA = "0x21B99F0", Offset = "0x21B81F0", Length = "0x9E")]
		[Token(Token = "0x600318F")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x21B9C40", Offset = "0x21B8440", Length = "0x9E")]
		[Token(Token = "0x6003190")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000031")]
	public event RelationshipUpdateHandler OnRelationshipUpdate
	{
		[CompilerGenerated]
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x21B9A90", Offset = "0x21B8290", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x21B9CE0", Offset = "0x21B84E0", Length = "0x9E")]
		[Token(Token = "0x6003192")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Address(RVA = "0x21B9810", Offset = "0x21B8010", Length = "0x1D1")]
	[Token(Token = "0x6003193")]
	internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Address(RVA = "0x21B9570", Offset = "0x21B7D70", Length = "0x10B")]
	[Token(Token = "0x6003194")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003195")]
	[Address(RVA = "0x21B9250", Offset = "0x21B7A50", Length = "0x83")]
	[MonoPInvokeCallback]
	private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
	{
		return default(bool);
	}

	[Token(Token = "0x6003196")]
	[Address(RVA = "0x21B92E0", Offset = "0x21B7AE0", Length = "0xEE")]
	public void Filter(FilterHandler callback)
	{
	}

	[Token(Token = "0x6003197")]
	[Address(RVA = "0x21B91A0", Offset = "0x21B79A0", Length = "0xAA")]
	public int Count()
	{
		return default(int);
	}

	[Address(RVA = "0x21B94A0", Offset = "0x21B7CA0", Length = "0xC0")]
	[Token(Token = "0x6003198")]
	public Relationship Get(long userId)
	{
		return default(Relationship);
	}

	[Address(RVA = "0x21B93D0", Offset = "0x21B7BD0", Length = "0xC0")]
	[Token(Token = "0x6003199")]
	public Relationship GetAt(uint index)
	{
		return default(Relationship);
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x600319A")]
	[Address(RVA = "0x21B9680", Offset = "0x21B7E80", Length = "0xB5")]
	private static void OnRefreshImpl(IntPtr ptr)
	{
	}

	[Token(Token = "0x600319B")]
	[MonoPInvokeCallback]
	[Address(RVA = "0x21B9740", Offset = "0x21B7F40", Length = "0xC5")]
	private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
	{
	}
}
