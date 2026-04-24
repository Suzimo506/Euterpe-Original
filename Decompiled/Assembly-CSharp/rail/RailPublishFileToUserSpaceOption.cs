using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000387")]
public class RailPublishFileToUserSpaceOption
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014CF")]
	public RailKeyValue key_value;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014D0")]
	public string description;

	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x20")]
	public List<string> tags;

	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x28")]
	public EnumRailSpaceWorkShareLevel level;

	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x30")]
	public string version;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014D4")]
	public string preview_path_filename;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014D5")]
	public EnumRailSpaceWorkType type;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014D6")]
	public string space_work_name;

	[Address(RVA = "0x2720F70", Offset = "0x271F770", Length = "0x91")]
	[Token(Token = "0x6002EF0")]
	public RailPublishFileToUserSpaceOption()
	{
	}
}
