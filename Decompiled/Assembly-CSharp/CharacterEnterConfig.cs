using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20000A9")]
public struct CharacterEnterConfig
{
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x0")]
	public int characterIndex;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000477")]
	public string assetName;

	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x10")]
	public string audioAssetName;

	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x18")]
	public string[] ignoreMusic;

	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x20")]
	public bool isReplaceBadapple;

	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400047B")]
	public bool isReplaceBadappleAudio;

	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x28")]
	public string enterAnimationKey_zh;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400047D")]
	public string enterAnimationKey_zht;

	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x38")]
	public string enterAnimationKey_jp;

	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x40")]
	public string enterAnimationKey_kor;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000480")]
	public string enterAnimationKey_en;
}
