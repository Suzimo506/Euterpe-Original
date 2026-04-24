using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000249")]
public class IRailNetworkImpl : RailObject, IRailNetwork
{
	[Token(Token = "0x600288C")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailNetworkImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600288D")]
	~IRailNetworkImpl()
	{
	}

	[Address(RVA = "0xD2E320", Offset = "0xD2CB20", Length = "0x22D")]
	[Token(Token = "0x600288E")]
	public virtual RailResult AcceptSessionRequest(RailID local_peer, RailID remote_peer)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600288F")]
	[Address(RVA = "0xD2FB50", Offset = "0xD2E350", Length = "0x24B")]
	public virtual RailResult SendData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002890")]
	[Address(RVA = "0xD2F900", Offset = "0xD2E100", Length = "0x241")]
	public virtual RailResult SendData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD301F0", Offset = "0xD2E9F0", Length = "0x24B")]
	[Token(Token = "0x6002891")]
	public virtual RailResult SendReliableData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2FFA0", Offset = "0xD2E7A0", Length = "0x241")]
	[Token(Token = "0x6002892")]
	public virtual RailResult SendReliableData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0xD2EB70", Offset = "0xD2D370", Length = "0x196")]
	public virtual bool IsDataReady(RailID local_peer, out uint data_len, out uint message_type)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref data_len) = null;
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref message_type) = null;
		return default(bool);
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0xD2ED10", Offset = "0xD2D510", Length = "0x18B")]
	public virtual bool IsDataReady(RailID local_peer, out uint data_len)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref data_len) = null;
		return default(bool);
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0xD2F110", Offset = "0xD2D910", Length = "0x26E")]
	public virtual RailResult ReadData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len, uint message_type)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2EEA0", Offset = "0xD2D6A0", Length = "0x264")]
	[Token(Token = "0x6002896")]
	public virtual RailResult ReadData(RailID local_peer, RailID remote_peer, byte[] data_buf, uint data_len)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2E550", Offset = "0xD2CD50", Length = "0x17B")]
	[Token(Token = "0x6002897")]
	public virtual RailResult BlockMessageType(RailID local_peer, uint message_type)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD30440", Offset = "0xD2EC40", Length = "0x17B")]
	[Token(Token = "0x6002898")]
	public virtual RailResult UnblockMessageType(RailID local_peer, uint message_type)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2E6D0", Offset = "0xD2CED0", Length = "0x22D")]
	[Token(Token = "0x6002899")]
	public virtual RailResult CloseSession(RailID local_peer, RailID remote_peer)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600289A")]
	[Address(RVA = "0xD2F7C0", Offset = "0xD2DFC0", Length = "0x132")]
	public virtual RailResult ResolveHostname(string domain, List<string> ip_list)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600289B")]
	[Address(RVA = "0xD2E970", Offset = "0xD2D170", Length = "0x1FE")]
	public virtual RailResult GetSessionState(RailID remote_peer, RailNetworkSessionState session_state)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600289C")]
	[Address(RVA = "0xD2E900", Offset = "0xD2D100", Length = "0x66")]
	public virtual RailResult ForbidSessionRelay(bool forbid_relay)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600289D")]
	[Address(RVA = "0xD2FDA0", Offset = "0xD2E5A0", Length = "0x1FF")]
	public virtual RailResult SendRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len, bool reliable, uint message_type)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2E140", Offset = "0xD2C940", Length = "0x1D9")]
	[Token(Token = "0x600289E")]
	public virtual RailResult AcceptRawSessionRequest(RailID local_peer, RailGamePeer remote_game_peer)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600289F")]
	[Address(RVA = "0xD2F5A0", Offset = "0xD2DDA0", Length = "0x21B")]
	public virtual RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len, uint message_type)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2F380", Offset = "0xD2DB80", Length = "0x211")]
	[Token(Token = "0x60028A0")]
	public virtual RailResult ReadRawData(RailID local_peer, RailGamePeer remote_game_peer, byte[] data_buf, uint data_len)
	{
		return default(RailResult);
	}
}
