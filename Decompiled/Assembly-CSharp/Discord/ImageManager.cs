using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Discord;

[Token(Token = "0x2000437")]
public class ImageManager
{
	[Token(Token = "0x2000AE6")]
	internal struct FFIEvents
	{
	}

	[Token(Token = "0x2000AE7")]
	internal struct FFIMethods
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E45")]
		internal delegate void FetchCallback(IntPtr ptr, Result result, ImageHandle handleResult);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E46")]
		internal delegate void FetchMethod(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E47")]
		internal delegate Result GetDimensionsMethod(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E48")]
		internal delegate Result GetDataMethod(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038EC")]
		internal FetchMethod Fetch;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40038ED")]
		internal GetDimensionsMethod GetDimensions;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038EE")]
		internal GetDataMethod GetData;
	}

	[Token(Token = "0x2000AE8")]
	public delegate void FetchHandler(Result result, ImageHandle handleResult);

	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x17000476")]
	private FFIMethods Methods
	{
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x21481A0", Offset = "0x21469A0", Length = "0x108")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Address(RVA = "0x2148070", Offset = "0x2146870", Length = "0x121")]
	[Token(Token = "0x6003185")]
	internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003186")]
	[Address(RVA = "0x2148000", Offset = "0x2146800", Length = "0x62")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003187")]
	[Address(RVA = "0x2147810", Offset = "0x2146010", Length = "0xB5")]
	private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
	{
	}

	[Address(RVA = "0x21478D0", Offset = "0x21460D0", Length = "0x110")]
	[Token(Token = "0x6003188")]
	public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback)
	{
	}

	[Address(RVA = "0x2147D30", Offset = "0x2146530", Length = "0xD7")]
	[Token(Token = "0x6003189")]
	public ImageDimensions GetDimensions(ImageHandle handle)
	{
		return default(ImageDimensions);
	}

	[Token(Token = "0x600318A")]
	[Address(RVA = "0x2147C40", Offset = "0x2146440", Length = "0xE6")]
	public void GetData(ImageHandle handle, byte[] data)
	{
	}

	[Address(RVA = "0x21479F0", Offset = "0x21461F0", Length = "0x100")]
	[Token(Token = "0x600318B")]
	public void Fetch(ImageHandle handle, FetchHandler callback)
	{
	}

	[Address(RVA = "0x2147B00", Offset = "0x2146300", Length = "0x13C")]
	[Token(Token = "0x600318C")]
	public byte[] GetData(ImageHandle handle)
	{
		return null;
	}

	[Address(RVA = "0x2147E10", Offset = "0x2146610", Length = "0x1EB")]
	[Token(Token = "0x600318D")]
	public Texture2D GetTexture(ImageHandle handle)
	{
		return null;
	}
}
