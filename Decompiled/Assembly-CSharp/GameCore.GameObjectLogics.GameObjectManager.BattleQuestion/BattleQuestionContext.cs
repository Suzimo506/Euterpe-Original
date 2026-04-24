using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Token(Token = "0x200047C")]
public class BattleQuestionContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400183B")]
	private BaseBattleQuestionView m_View;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400183C")]
	private BattleQuestionData m_Data;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400183D")]
	private BattleQuestionState m_QuestionState;

	[Token(Token = "0x170004A1")]
	public BattleQuestionData Data
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x600337D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A2")]
	public BaseBattleQuestionView View
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x600337E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A3")]
	public BattleQuestionState CurQuestionInfo
	{
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x7322C0", Offset = "0x730AC0", Length = "0xB")]
		get
		{
			return default(BattleQuestionState);
		}
	}

	[Token(Token = "0x6003380")]
	[Address(RVA = "0x837D80", Offset = "0x836580", Length = "0x3B")]
	public void ResetShowQuestion()
	{
	}

	[Address(RVA = "0x837D70", Offset = "0x836570", Length = "0x8")]
	[Token(Token = "0x6003381")]
	public void ClearShowQuestion()
	{
	}

	[Token(Token = "0x6003382")]
	[Address(RVA = "0x837D00", Offset = "0x836500", Length = "0x6E")]
	public void BindData()
	{
	}

	[Token(Token = "0x6003383")]
	[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
	public void BindView(BaseBattleQuestionView view)
	{
	}

	[Token(Token = "0x6003384")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BattleQuestionContext()
	{
	}
}
