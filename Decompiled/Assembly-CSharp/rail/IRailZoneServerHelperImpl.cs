using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200025E")]
public class IRailZoneServerHelperImpl : RailObject, IRailZoneServerHelper
{
	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailZoneServerHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x60029E5")]
	~IRailZoneServerHelperImpl()
	{
	}

	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x37CC00", Offset = "0x37B400", Length = "0xEB")]
	public virtual RailZoneID GetPlayerSelectedZoneID()
	{
		return null;
	}

	[Token(Token = "0x60029E7")]
	[Address(RVA = "0x37CCF0", Offset = "0x37B4F0", Length = "0xEB")]
	public virtual RailZoneID GetRootZoneID()
	{
		return null;
	}

	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x37CDE0", Offset = "0x37B5E0", Length = "0x216")]
	public virtual IRailZoneServer OpenZoneServer(RailZoneID zone_id, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x37CA20", Offset = "0x37B220", Length = "0x1D1")]
	public virtual RailResult AsyncSwitchPlayerSelectedZone(RailZoneID zone_id)
	{
		return default(RailResult);
	}
}
