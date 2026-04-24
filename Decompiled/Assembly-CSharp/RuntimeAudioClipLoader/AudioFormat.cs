using Cpp2ILInjected;

namespace RuntimeAudioClipLoader;

[Token(Token = "0x20001DD")]
public enum AudioFormat
{
	[Token(Token = "0x4000BC3")]
	wav = 0,
	[Token(Token = "0x4000BC4")]
	mp3 = 1,
	[Token(Token = "0x4000BC5")]
	aiff = 2,
	[Token(Token = "0x4000BC6")]
	ogg = 3,
	[Token(Token = "0x4000BC7")]
	unknown = -1
}
