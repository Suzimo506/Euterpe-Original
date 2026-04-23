using System.Collections.Generic;
using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Token(Token = "0x2000481")]
public class BattleQuestionData
{
	[Token(Token = "0x400184C")]
	private static BattleQuestionData s_Instance;

	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x10")]
	private bool m_DataInited;

	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x18")]
	private BattleQuestionState m_QuestionState;

	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x28")]
	private List<DBBattleQuestion> m_BattleQuestionList;

	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x30")]
	private List<DBLocalizedBattleQuestion> m_BattleQuestionLocalizedList;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x38")]
	private int m_ShowQuestionNumber;

	[Token(Token = "0x170004AE")]
	public static BattleQuestionData Instance
	{
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x838F30", Offset = "0x837730", Length = "0x72")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AF")]
	public int ShowQuestionNum
	{
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		[Token(Token = "0x600339A")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x838A90", Offset = "0x837290", Length = "0x27A")]
	[Token(Token = "0x600339B")]
	public BattleQuestionData InitData()
	{
		return null;
	}

	[Address(RVA = "0x838D10", Offset = "0x837510", Length = "0x21E")]
	[Token(Token = "0x600339C")]
	public BattleQuestionState RandomSelectQuestion()
	{
		return default(BattleQuestionState);
	}

	[Token(Token = "0x600339D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BattleQuestionData()
	{
	}
}
