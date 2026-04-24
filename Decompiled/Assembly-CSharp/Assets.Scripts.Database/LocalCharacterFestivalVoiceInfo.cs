using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A3")]
public class LocalCharacterFestivalVoiceInfo : BaseDataObject
{
	[Token(Token = "0x4002885")]
	[FieldOffset(Offset = "0x20")]
	public List<List<string>> expressions;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002886")]
	public List<List<string>> reviewExpressions;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x6004702")]
	public LocalCharacterFestivalVoiceInfo()
	{
	}
}
