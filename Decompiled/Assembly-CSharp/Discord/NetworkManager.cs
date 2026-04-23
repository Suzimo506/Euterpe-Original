using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200043A")]
public class NetworkManager
{
	[Token(Token = "0x2000B03")]
	internal struct FFIEvents
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E84")]
		internal delegate void MessageHandler(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen);

		[Token(Token = "0x2000E85")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void RouteUpdateHandler(IntPtr ptr, string routeData);

		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0x0")]
		internal MessageHandler OnMessage;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400391F")]
		internal RouteUpdateHandler OnRouteUpdate;
	}

	[Token(Token = "0x2000B04")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E86")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void GetPeerIdMethod(IntPtr methodsPtr, ref ulong peerId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E87")]
		internal delegate Result FlushMethod(IntPtr methodsPtr);

		[Token(Token = "0x2000E88")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result OpenPeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

		[Token(Token = "0x2000E89")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result UpdatePeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

		[Token(Token = "0x2000E8A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result ClosePeerMethod(IntPtr methodsPtr, ulong peerId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E8B")]
		internal delegate Result OpenChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable);

		[Token(Token = "0x2000E8C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result CloseChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E8D")]
		internal delegate Result SendMessageMethod(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003920")]
		internal GetPeerIdMethod GetPeerId;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003921")]
		internal FlushMethod Flush;

		[Token(Token = "0x4003922")]
		[FieldOffset(Offset = "0x10")]
		internal OpenPeerMethod OpenPeer;

		[Token(Token = "0x4003923")]
		[FieldOffset(Offset = "0x18")]
		internal UpdatePeerMethod UpdatePeer;

		[Token(Token = "0x4003924")]
		[FieldOffset(Offset = "0x20")]
		internal ClosePeerMethod ClosePeer;

		[Token(Token = "0x4003925")]
		[FieldOffset(Offset = "0x28")]
		internal OpenChannelMethod OpenChannel;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003926")]
		internal CloseChannelMethod CloseChannel;

		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003927")]
		internal SendMessageMethod SendMessage;
	}

	[Token(Token = "0x2000B05")]
	public delegate void MessageHandler(ulong peerId, byte channelId, byte[] data);

	[Token(Token = "0x2000B06")]
	public delegate void RouteUpdateHandler(string routeData);

	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x17000479")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x21B7080", Offset = "0x21B5880", Length = "0x116")]
		[Token(Token = "0x60031E5")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x1400003A")]
	public event MessageHandler OnMessage
	{
		[CompilerGenerated]
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x21B6F40", Offset = "0x21B5740", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x21B71A0", Offset = "0x21B59A0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400003B")]
	public event RouteUpdateHandler OnRouteUpdate
	{
		[CompilerGenerated]
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x21B6FE0", Offset = "0x21B57E0", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x21B7240", Offset = "0x21B5A40", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60031E9")]
		remove
		{
		}
	}

	[Token(Token = "0x60031EA")]
	[Address(RVA = "0x21B6D60", Offset = "0x21B5560", Length = "0x1D1")]
	internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x21B66F0", Offset = "0x21B4EF0", Length = "0x10B")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x60031EC")]
	[Address(RVA = "0x21B6690", Offset = "0x21B4E90", Length = "0x5A")]
	public ulong GetPeerId()
	{
		return default(ulong);
	}

	[Address(RVA = "0x21B65F0", Offset = "0x21B4DF0", Length = "0x9C")]
	[Token(Token = "0x60031ED")]
	public void Flush()
	{
	}

	[Token(Token = "0x60031EE")]
	[Address(RVA = "0x21B6B00", Offset = "0x21B5300", Length = "0xB3")]
	public void OpenPeer(ulong peerId, string routeData)
	{
	}

	[Address(RVA = "0x21B6CA0", Offset = "0x21B54A0", Length = "0xB3")]
	[Token(Token = "0x60031EF")]
	public void UpdatePeer(ulong peerId, string routeData)
	{
	}

	[Address(RVA = "0x21B6550", Offset = "0x21B4D50", Length = "0x9E")]
	[Token(Token = "0x60031F0")]
	public void ClosePeer(ulong peerId)
	{
	}

	[Address(RVA = "0x21B6A30", Offset = "0x21B5230", Length = "0xC7")]
	[Token(Token = "0x60031F1")]
	public void OpenChannel(ulong peerId, byte channelId, bool reliable)
	{
	}

	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x21B6490", Offset = "0x21B4C90", Length = "0xB5")]
	public void CloseChannel(ulong peerId, byte channelId)
	{
	}

	[Address(RVA = "0x21B6BC0", Offset = "0x21B53C0", Length = "0xDF")]
	[Token(Token = "0x60031F3")]
	public void SendMessage(ulong peerId, byte channelId, byte[] data)
	{
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x21B6800", Offset = "0x21B5000", Length = "0x15B")]
	[Token(Token = "0x60031F4")]
	private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
	{
	}

	[Address(RVA = "0x21B6960", Offset = "0x21B5160", Length = "0xC5")]
	[MonoPInvokeCallback]
	[Token(Token = "0x60031F5")]
	private static void OnRouteUpdateImpl(IntPtr ptr, string routeData)
	{
	}
}
