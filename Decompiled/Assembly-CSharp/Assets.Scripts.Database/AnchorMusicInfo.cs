using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200078F")]
internal struct AnchorMusicInfo
{
	[Token(Token = "0x40027F8")]
	[FieldOffset(Offset = "0x0")]
	public string object_id;

	[Token(Token = "0x40027F9")]
	[FieldOffset(Offset = "0x8")]
	public DateTime created_at;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40027FA")]
	public DateTime updated_at;

	[Token(Token = "0x40027FB")]
	[FieldOffset(Offset = "0x18")]
	public string uid;

	[Token(Token = "0x40027FC")]
	[FieldOffset(Offset = "0x20")]
	public string name;

	[Token(Token = "0x40027FD")]
	[FieldOffset(Offset = "0x28")]
	public string author;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40027FE")]
	public string bpm;

	[Token(Token = "0x40027FF")]
	[FieldOffset(Offset = "0x38")]
	public string music;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002800")]
	public string demo;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002801")]
	public string cover;

	[Token(Token = "0x4002802")]
	[FieldOffset(Offset = "0x50")]
	public string noteJson;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002803")]
	public string scene;

	[Token(Token = "0x4002804")]
	[FieldOffset(Offset = "0x60")]
	public string levelDesigner;

	[Token(Token = "0x4002805")]
	[FieldOffset(Offset = "0x68")]
	public string difficulty1;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002806")]
	public string difficulty2;

	[Token(Token = "0x4002807")]
	[FieldOffset(Offset = "0x78")]
	public string difficulty3;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002808")]
	public string difficulty4;

	[Token(Token = "0x4002809")]
	[FieldOffset(Offset = "0x88")]
	public int unlockLevel;

	[Token(Token = "0x400280A")]
	[FieldOffset(Offset = "0x8C")]
	public bool is_anchor_user;

	[FieldOffset(Offset = "0x8D")]
	[Token(Token = "0x400280B")]
	public bool is_delete;
}
