using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200043C")]
public class StorageManager
{
	[Token(Token = "0x2000B0E")]
	internal struct FFIEvents
	{
	}

	[Token(Token = "0x2000B0F")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E99")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result ReadMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read);

		[Token(Token = "0x2000E9A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ReadAsyncCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E9B")]
		internal delegate void ReadAsyncMethod(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E9C")]
		internal delegate void ReadAsyncPartialCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E9D")]
		internal delegate void ReadAsyncPartialMethod(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback);

		[Token(Token = "0x2000E9E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result WriteMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E9F")]
		internal delegate void WriteAsyncCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EA0")]
		internal delegate void WriteAsyncMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EA1")]
		internal delegate Result DeleteMethod(IntPtr methodsPtr, string name);

		[Token(Token = "0x2000EA2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result ExistsMethod(IntPtr methodsPtr, string name, ref bool exists);

		[Token(Token = "0x2000EA3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void CountMethod(IntPtr methodsPtr, ref int count);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EA4")]
		internal delegate Result StatMethod(IntPtr methodsPtr, string name, ref FileStat stat);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EA5")]
		internal delegate Result StatAtMethod(IntPtr methodsPtr, int index, ref FileStat stat);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EA6")]
		internal delegate Result GetPathMethod(IntPtr methodsPtr, StringBuilder path);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400392F")]
		internal ReadMethod Read;

		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x8")]
		internal ReadAsyncMethod ReadAsync;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003931")]
		internal ReadAsyncPartialMethod ReadAsyncPartial;

		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x18")]
		internal WriteMethod Write;

		[Token(Token = "0x4003933")]
		[FieldOffset(Offset = "0x20")]
		internal WriteAsyncMethod WriteAsync;

		[Token(Token = "0x4003934")]
		[FieldOffset(Offset = "0x28")]
		internal DeleteMethod Delete;

		[Token(Token = "0x4003935")]
		[FieldOffset(Offset = "0x30")]
		internal ExistsMethod Exists;

		[Token(Token = "0x4003936")]
		[FieldOffset(Offset = "0x38")]
		internal CountMethod Count;

		[Token(Token = "0x4003937")]
		[FieldOffset(Offset = "0x40")]
		internal StatMethod Stat;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003938")]
		internal StatAtMethod StatAt;

		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003939")]
		internal GetPathMethod GetPath;
	}

	[Token(Token = "0x2000B10")]
	public delegate void ReadAsyncHandler(Result result, byte[] data);

	[Token(Token = "0x2000B11")]
	public delegate void ReadAsyncPartialHandler(Result result, byte[] data);

	[Token(Token = "0x2000B12")]
	public delegate void WriteAsyncHandler(Result result);

	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x1700047B")]
	private FFIMethods Methods
	{
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x21BC740", Offset = "0x21BAF40", Length = "0x128")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Address(RVA = "0x21BC610", Offset = "0x21BAE10", Length = "0x121")]
	[Token(Token = "0x6003207")]
	internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003208")]
	[Address(RVA = "0x21BBC80", Offset = "0x21BA480", Length = "0x62")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003209")]
	[Address(RVA = "0x21BC100", Offset = "0x21BA900", Length = "0xE5")]
	public uint Read(string name, byte[] data)
	{
		return default(uint);
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x600320A")]
	[Address(RVA = "0x21BBCF0", Offset = "0x21BA4F0", Length = "0xFF")]
	private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
	{
	}

	[Address(RVA = "0x21BC000", Offset = "0x21BA800", Length = "0xF3")]
	[Token(Token = "0x600320B")]
	public void ReadAsync(string name, ReadAsyncHandler callback)
	{
	}

	[Address(RVA = "0x21BBDF0", Offset = "0x21BA5F0", Length = "0xFF")]
	[MonoPInvokeCallback]
	[Token(Token = "0x600320C")]
	private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
	{
	}

	[Address(RVA = "0x21BBEF0", Offset = "0x21BA6F0", Length = "0x104")]
	[Token(Token = "0x600320D")]
	public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback)
	{
	}

	[Address(RVA = "0x21BC540", Offset = "0x21BAD40", Length = "0xCC")]
	[Token(Token = "0x600320E")]
	public void Write(string name, byte[] data)
	{
	}

	[Token(Token = "0x600320F")]
	[MonoPInvokeCallback]
	[Address(RVA = "0x21BC390", Offset = "0x21BAB90", Length = "0x90")]
	private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003210")]
	[Address(RVA = "0x21BC430", Offset = "0x21BAC30", Length = "0x10D")]
	public void WriteAsync(string name, byte[] data, WriteAsyncHandler callback)
	{
	}

	[Token(Token = "0x6003211")]
	[Address(RVA = "0x21BB850", Offset = "0x21BA050", Length = "0xA1")]
	public void Delete(string name)
	{
	}

	[Token(Token = "0x6003212")]
	[Address(RVA = "0x21BB900", Offset = "0x21BA100", Length = "0xBF")]
	public bool Exists(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6003213")]
	[Address(RVA = "0x21BB7F0", Offset = "0x21B9FF0", Length = "0x56")]
	public int Count()
	{
		return default(int);
	}

	[Address(RVA = "0x21BC2C0", Offset = "0x21BAAC0", Length = "0xC5")]
	[Token(Token = "0x6003214")]
	public FileStat Stat(string name)
	{
		return default(FileStat);
	}

	[Address(RVA = "0x21BC1F0", Offset = "0x21BA9F0", Length = "0xC5")]
	[Token(Token = "0x6003215")]
	public FileStat StatAt(int index)
	{
		return default(FileStat);
	}

	[Address(RVA = "0x21BBB90", Offset = "0x21BA390", Length = "0xE1")]
	[Token(Token = "0x6003216")]
	public string GetPath()
	{
		return null;
	}

	[Token(Token = "0x6003217")]
	[Address(RVA = "0x21BB9C0", Offset = "0x21BA1C0", Length = "0x1CB")]
	public IEnumerable<FileStat> Files()
	{
		return null;
	}
}
