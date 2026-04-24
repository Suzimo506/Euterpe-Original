using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000791")]
internal struct AnchorBanBgmInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400280C")]
	public string object_id;

	[Token(Token = "0x400280D")]
	[FieldOffset(Offset = "0x8")]
	public DateTime created_at;

	[Token(Token = "0x400280E")]
	[FieldOffset(Offset = "0x10")]
	public DateTime updated_at;

	[Token(Token = "0x400280F")]
	[FieldOffset(Offset = "0x18")]
	public string bgm_name;

	[Token(Token = "0x4002810")]
	[FieldOffset(Offset = "0x20")]
	public string bgm_file_name;

	[Token(Token = "0x4002811")]
	[FieldOffset(Offset = "0x28")]
	public string note;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002812")]
	public string author;

	[Token(Token = "0x4002813")]
	[FieldOffset(Offset = "0x38")]
	public bool is_anchor_user;

	[Token(Token = "0x4002814")]
	[FieldOffset(Offset = "0x39")]
	public bool is_delete;
}
