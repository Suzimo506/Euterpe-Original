using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200025D")]
public class IRailZoneServerImpl : RailObject, IRailZoneServer, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x60029D4")]
	internal IRailZoneServerImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60029D5")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailZoneServerImpl()
	{
	}

	[Address(RVA = "0x37D960", Offset = "0x37C160", Length = "0xEB")]
	[Token(Token = "0x60029D6")]
	public virtual RailZoneID GetZoneID()
	{
		return null;
	}

	[Address(RVA = "0x37DBE0", Offset = "0x37C3E0", Length = "0x18B")]
	[Token(Token = "0x60029D7")]
	public virtual RailResult GetZoneNameLanguages(List<string> languages)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x37DD70", Offset = "0x37C570", Length = "0x206")]
	public virtual RailResult GetZoneName(string language_filter, out string zone_name)
	{
		zone_name = null;
		return default(RailResult);
	}

	[Address(RVA = "0x37D440", Offset = "0x37BC40", Length = "0x18B")]
	[Token(Token = "0x60029D9")]
	public virtual RailResult GetZoneDescriptionLanguages(List<string> languages)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37D5D0", Offset = "0x37BDD0", Length = "0x206")]
	[Token(Token = "0x60029DA")]
	public virtual RailResult GetZoneDescription(string language_filter, out string zone_description)
	{
		zone_description = null;
		return default(RailResult);
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x37D2B0", Offset = "0x37BAB0", Length = "0x18B")]
	public virtual RailResult GetGameServerAddresses(List<string> server_addresses)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x37DA50", Offset = "0x37C250", Length = "0x18B")]
	public virtual RailResult GetZoneMetadatas(List<RailKeyValue> key_values)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x37D000", Offset = "0x37B800", Length = "0x247")]
	public virtual RailResult GetChildrenZoneIDs(List<RailZoneID> zone_ids)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x37E040", Offset = "0x37C840", Length = "0xBA")]
	[Token(Token = "0x60029DE")]
	public virtual bool IsZoneVisiable()
	{
		return default(bool);
	}

	[Address(RVA = "0x37DF80", Offset = "0x37C780", Length = "0xBA")]
	[Token(Token = "0x60029DF")]
	public virtual bool IsZoneJoinable()
	{
		return default(bool);
	}

	[Address(RVA = "0x37D8A0", Offset = "0x37C0A0", Length = "0xB5")]
	[Token(Token = "0x60029E0")]
	public virtual uint GetZoneEnableStartTime()
	{
		return default(uint);
	}

	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x37D7E0", Offset = "0x37BFE0", Length = "0xB5")]
	public virtual uint GetZoneEnableEndTime()
	{
		return default(uint);
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x37D250", Offset = "0x37BA50", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x37E100", Offset = "0x37C900", Length = "0x55")]
	public virtual void Release()
	{
	}
}
