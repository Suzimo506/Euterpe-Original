using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003EE")]
public interface IRailZoneServer : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC0")]
	RailZoneID GetZoneID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC1")]
	RailResult GetZoneNameLanguages(List<string> languages);

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetZoneName(string language_filter, out string zone_name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC3")]
	RailResult GetZoneDescriptionLanguages(List<string> languages);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC4")]
	RailResult GetZoneDescription(string language_filter, out string zone_description);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC5")]
	RailResult GetGameServerAddresses(List<string> server_addresses);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC6")]
	RailResult GetZoneMetadatas(List<RailKeyValue> key_values);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC7")]
	RailResult GetChildrenZoneIDs(List<RailZoneID> zone_ids);

	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsZoneVisiable();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FC9")]
	bool IsZoneJoinable();

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetZoneEnableStartTime();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002FCB")]
	uint GetZoneEnableEndTime();
}
