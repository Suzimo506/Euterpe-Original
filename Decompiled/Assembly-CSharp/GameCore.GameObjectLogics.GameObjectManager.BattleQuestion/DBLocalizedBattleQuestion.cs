using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Serializable]
[Token(Token = "0x200047F")]
public class DBLocalizedBattleQuestion
{
	[JsonProperty]
	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x10")]
	private string m_QuestionId;

	[JsonProperty]
	[Token(Token = "0x4001846")]
	[FieldOffset(Offset = "0x18")]
	private string m_QuestionStr;

	[JsonProperty]
	[Token(Token = "0x4001847")]
	[FieldOffset(Offset = "0x20")]
	private string m_RightAnswer;

	[FieldOffset(Offset = "0x28")]
	[JsonProperty]
	[Token(Token = "0x4001848")]
	private string m_WrongAnswer;

	[Token(Token = "0x170004AA")]
	public string QuestionId
	{
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AB")]
	public string QuestionStr
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6003395")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AC")]
	public string RightAnswer
	{
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AD")]
	public string WrongAnswer
	{
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003398")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DBLocalizedBattleQuestion()
	{
	}
}
