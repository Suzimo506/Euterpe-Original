using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[Token(Token = "0x200051B")]
public enum NoteType : uint
{
	[Token(Token = "0x4001CD1")]
	None,
	[Token(Token = "0x4001CD2")]
	Monster,
	[Token(Token = "0x4001CD3")]
	Block,
	[Token(Token = "0x4001CD4")]
	Press,
	[Token(Token = "0x4001CD5")]
	Hide,
	[Token(Token = "0x4001CD6")]
	Boss,
	[Token(Token = "0x4001CD7")]
	Hp,
	[Token(Token = "0x4001CD8")]
	Music,
	[Token(Token = "0x4001CD9")]
	Mul,
	[Token(Token = "0x4001CDA")]
	SceneChange,
	[Token(Token = "0x4001CDB")]
	AutoOn,
	[Token(Token = "0x4001CDC")]
	AutoOff,
	[Token(Token = "0x4001CDD")]
	DisappearOn,
	[Token(Token = "0x4001CDE")]
	DisappearOff,
	[Token(Token = "0x4001CDF")]
	DisappearBossOn,
	[Token(Token = "0x4001CE0")]
	DisappearBossOff,
	[Token(Token = "0x4001CE1")]
	SceneHideOn,
	[Token(Token = "0x4001CE2")]
	SceneHideOff
}
