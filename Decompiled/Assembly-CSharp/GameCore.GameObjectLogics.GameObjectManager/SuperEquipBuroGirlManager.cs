using Cpp2ILInjected;
using FormulaBase;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000478")]
public class SuperEquipBuroGirlManager : GeneralFloatGirlManager
{
	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsAutoPlayMulitEnemy;

	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0x94")]
	private float m_LastMultiNoteHitTime;

	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0x98")]
	private float m_MultiHitDuration;

	[Token(Token = "0x4001832")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_IsSkillInvalidate;

	[Address(RVA = "0x90DDF0", Offset = "0x90C5F0", Length = "0x80")]
	[Token(Token = "0x6003363")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6003364")]
	[Address(RVA = "0x90DF00", Offset = "0x90C700", Length = "0x61")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x6003365")]
	[Address(RVA = "0x90DE80", Offset = "0x90C680", Length = "0x73")]
	public void SetAutoPlayMultiEnemyState(bool isAutoPlay)
	{
	}

	[Address(RVA = "0x90DB40", Offset = "0x90C340", Length = "0x2AC")]
	[Token(Token = "0x6003366")]
	public void AutoPlayMultiEnemy(TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x6003367")]
	[Address(RVA = "0x7DD280", Offset = "0x7DBA80", Length = "0x7")]
	public SuperEquipBuroGirlManager()
	{
	}
}
