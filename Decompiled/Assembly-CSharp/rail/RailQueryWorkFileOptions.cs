using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003AE")]
public class RailQueryWorkFileOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001542")]
	public bool with_url;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001543")]
	public bool with_uploader_ids;

	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x12")]
	public bool with_vote_detail;

	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4001545")]
	public bool with_preview_url;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001546")]
	public bool with_description;

	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x4001547")]
	public bool query_total_only;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001548")]
	public uint preview_scaling_rate;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F56")]
	public RailQueryWorkFileOptions()
	{
	}
}
