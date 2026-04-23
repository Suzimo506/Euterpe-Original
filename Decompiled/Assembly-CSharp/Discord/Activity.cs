using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000425")]
public struct Activity
{
	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x0")]
	public ActivityType Type;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001720")]
	public long ApplicationId;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001721")]
	public string Name;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001722")]
	public string State;

	[Token(Token = "0x4001723")]
	[FieldOffset(Offset = "0x20")]
	public string Details;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001724")]
	public ActivityTimestamps Timestamps;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001725")]
	public ActivityAssets Assets;

	[Token(Token = "0x4001726")]
	[FieldOffset(Offset = "0x58")]
	public ActivityParty Party;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001727")]
	public ActivitySecrets Secrets;

	[Token(Token = "0x4001728")]
	[FieldOffset(Offset = "0x80")]
	public bool Instance;
}
