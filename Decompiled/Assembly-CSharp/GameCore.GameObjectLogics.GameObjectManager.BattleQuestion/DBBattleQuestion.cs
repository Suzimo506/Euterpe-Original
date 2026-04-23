using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Serializable]
[Token(Token = "0x200047E")]
public class DBBattleQuestion
{
	[FieldOffset(Offset = "0x10")]
	[JsonProperty]
	[Token(Token = "0x4001844")]
	private string m_QuestionId;

	[Token(Token = "0x170004A9")]
	public string QuestionId
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x6003392")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003393")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DBBattleQuestion()
	{
	}
}
