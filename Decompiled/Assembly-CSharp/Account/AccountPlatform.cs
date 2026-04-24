using Cpp2ILInjected;

namespace Account;

[Token(Token = "0x2000561")]
public enum AccountPlatform
{
	[Token(Token = "0x4001FBF")]
	pc,
	[Token(Token = "0x4001FC0")]
	pc_overseas,
	[Token(Token = "0x4001FC1")]
	ios,
	[Token(Token = "0x4001FC2")]
	ios_overseas,
	[Token(Token = "0x4001FC3")]
	android_taptap,
	[Token(Token = "0x4001FC4")]
	android_google,
	[Token(Token = "0x4001FC5")]
	pc_wegame,
	[Token(Token = "0x4001FC6")]
	nintendo_switch
}
