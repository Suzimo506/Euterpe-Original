using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003AF")]
public class RailSpaceWorkDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001549")]
	public List<RailSpaceWorkVoteDetail> vote_details;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400154A")]
	public string description;

	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x20")]
	public string preview_scaling_url;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400154C")]
	public string recommendation_rate;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400154D")]
	public string preview_url;

	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x38")]
	public SpaceWorkID id;

	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x40")]
	public uint create_time;

	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x48")]
	public string detail_url;

	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x50")]
	public List<RailID> uploader_ids;

	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x58")]
	public string name;

	[Address(RVA = "0x27211F0", Offset = "0x271F9F0", Length = "0xF7")]
	[Token(Token = "0x6002F57")]
	public RailSpaceWorkDescriptor()
	{
	}
}
