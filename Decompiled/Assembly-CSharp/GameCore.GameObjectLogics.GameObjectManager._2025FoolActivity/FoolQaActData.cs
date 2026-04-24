using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager._2025FoolActivity;

[Token(Token = "0x2000483")]
public class FoolQaActData
{
	[Token(Token = "0x4001863")]
	public const int boss_default_battle_point = 1000;

	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x10")]
	private int m_RoleBattlePoint;

	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x14")]
	private int m_BossBattlePoint;

	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x18")]
	private int m_SelectedRoleIdBeforeReplace;

	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x1C")]
	private int m_SelectedElfinIdBeforeReplace;

	[Token(Token = "0x170004B1")]
	public int RoleBattlePoint
	{
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004B2")]
	public int BossBattlePoint
	{
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x8F7470", Offset = "0x8F5C70", Length = "0x4D")]
	public void InitBattlePoint()
	{
	}

	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x8F74C0", Offset = "0x8F5CC0", Length = "0x24")]
	public void ResetBattlePoint(int rolePoint = 0, int bossPoint = 0)
	{
	}

	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FoolQaActData()
	{
	}
}
