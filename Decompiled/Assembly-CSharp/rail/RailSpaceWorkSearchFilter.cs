using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B1")]
public class RailSpaceWorkSearchFilter
{
	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x10")]
	public string search_text;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001559")]
	public bool match_all_required_tags;

	[Token(Token = "0x400155A")]
	[FieldOffset(Offset = "0x20")]
	public List<RailKeyValue> required_metadata;

	[Token(Token = "0x400155B")]
	[FieldOffset(Offset = "0x28")]
	public bool match_all_required_metadata;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400155C")]
	public List<string> required_tags;

	[Token(Token = "0x400155D")]
	[FieldOffset(Offset = "0x38")]
	public List<RailKeyValue> excluded_metadata;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400155E")]
	public List<string> excluded_tags;

	[Address(RVA = "0x2721410", Offset = "0x271FC10", Length = "0xF0")]
	[Token(Token = "0x6002F59")]
	public RailSpaceWorkSearchFilter()
	{
	}
}
