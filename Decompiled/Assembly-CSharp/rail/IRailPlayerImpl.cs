using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200024A")]
public class IRailPlayerImpl : RailObject, IRailPlayer
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x60028A1")]
	internal IRailPlayerImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60028A2")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailPlayerImpl()
	{
	}

	[Address(RVA = "0x368450", Offset = "0x366C50", Length = "0xBA")]
	[Token(Token = "0x60028A3")]
	public virtual bool AlreadyLoggedIn()
	{
		return default(bool);
	}

	[Address(RVA = "0x3693C0", Offset = "0x367BC0", Length = "0xEB")]
	[Token(Token = "0x60028A4")]
	public virtual RailID GetRailID()
	{
		return null;
	}

	[Token(Token = "0x60028A5")]
	[Address(RVA = "0x368F20", Offset = "0x367720", Length = "0x1E9")]
	public virtual RailResult GetPlayerDataPath(out string path)
	{
		path = null;
		return default(RailResult);
	}

	[Address(RVA = "0x368510", Offset = "0x366D10", Length = "0xDD")]
	[Token(Token = "0x60028A6")]
	public virtual RailResult AsyncAcquireSessionTicket(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x368CC0", Offset = "0x3674C0", Length = "0x25B")]
	[Token(Token = "0x60028A7")]
	public virtual RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028A8")]
	[Address(RVA = "0x369630", Offset = "0x367E30", Length = "0x1C1")]
	public virtual void TerminateSessionOfPlayer(RailID player_rail_id)
	{
	}

	[Token(Token = "0x60028A9")]
	[Address(RVA = "0x3682E0", Offset = "0x366AE0", Length = "0x16E")]
	public virtual void AbandonSessionTicket(RailSessionTicket session_ticket)
	{
	}

	[Token(Token = "0x60028AA")]
	[Address(RVA = "0x369110", Offset = "0x367910", Length = "0x1E9")]
	public virtual RailResult GetPlayerName(out string name)
	{
		name = null;
		return default(RailResult);
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x369300", Offset = "0x367B00", Length = "0xB5")]
	public virtual EnumRailPlayerOwnershipType GetPlayerOwnershipType()
	{
		return default(EnumRailPlayerOwnershipType);
	}

	[Address(RVA = "0x368950", Offset = "0x367150", Length = "0xDD")]
	[Token(Token = "0x60028AC")]
	public virtual RailResult AsyncGetGamePurchaseKey(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x369570", Offset = "0x367D70", Length = "0xBA")]
	public virtual bool IsGameRevenueLimited()
	{
		return default(bool);
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x3694B0", Offset = "0x367CB0", Length = "0xB5")]
	public virtual float GetRateOfGameRevenue()
	{
		return default(float);
	}

	[Address(RVA = "0x368BE0", Offset = "0x3673E0", Length = "0xDD")]
	[Token(Token = "0x60028AF")]
	public virtual RailResult AsyncQueryPlayerBannedStatus(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3685F0", Offset = "0x366DF0", Length = "0x25D")]
	[Token(Token = "0x60028B0")]
	public virtual RailResult AsyncGetAuthenticateURL(RailGetAuthenticateURLOptions options, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x368A30", Offset = "0x367230", Length = "0x1A0")]
	public virtual RailResult AsyncGetPlayerMetadata(List<string> keys, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x368850", Offset = "0x367050", Length = "0x100")]
	public virtual RailResult AsyncGetEncryptedGameTicket(string set_metadata, string user_data)
	{
		return default(RailResult);
	}
}
